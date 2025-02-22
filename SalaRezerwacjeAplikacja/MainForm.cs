using System;
using System.Linq;
using System.Windows.Forms;
using SalaRezerwacjeAplikacja.Data;
using System.Windows.Forms.VisualStyles;
using SalaRezerwacjeAplikacja.Models;

namespace SalaRezerwacjeAplikacja;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    // Gdy formularz siê za³aduje
    private void MainForm_Load(object sender, EventArgs e)
    {
        OdswiezListeSal();
        OdswiezListeRezerwacji();
        ZaladujComboBoxSale();
    }

    private void ZaladujComboBoxSale()
    {
        using (var db = new AppDbContext())
        {
            var rooms = db.Rooms.ToList();
            comboBoxSale.DataSource = rooms;      // Lista sal
            comboBoxSale.DisplayMember = "Name";  // Wyœwietlamy nazwê sali
            comboBoxSale.ValueMember = "RoomId";  // Pod spodem ID sali
        }
    }

    // Odœwie¿a DataGridView z salami
    private void OdswiezListeSal()
    {
        using (var db = new AppDbContext())
        {
            var rooms = db.Rooms.ToList();
            dataGridViewRooms.DataSource = rooms;
        }
    }

    // Odœwie¿a DataGridView z rezerwacjami
    private void OdswiezListeRezerwacji()
    {
        using (var db = new AppDbContext())
        {
            // Pobierz rezerwacje wraz z nazw¹ sali
            var reservations = db.Reservations
                                 .Select(r => new
                                 {
                                     r.ReservationId,
                                     RoomName = r.Room.Name,
                                     r.StartTime,
                                     r.EndTime,
                                     r.ReservedBy
                                 })
                                 .ToList();

            dataGridViewReservations.DataSource = reservations;
        }
    }

    // Obs³uga przycisku "Dodaj salê"
    private void buttonDodajSale_Click(object sender, EventArgs e)
    {
        using (var db = new AppDbContext())
        {
            var room = new Room
            {
                Name = textBoxNazwaSali.Text,
                Capacity = (int)numericUpDownPojemnosc.Value
            };
            db.Rooms.Add(room);
            db.SaveChanges();
        }
        OdswiezListeSal();
        ZaladujComboBoxSale();
    }

    // Obs³uga przycisku "Usuñ salê"
    private void buttonUsunSale_Click(object sender, EventArgs e)
    {
        if (dataGridViewRooms.CurrentRow != null)
        {
            int roomId = (int)dataGridViewRooms.CurrentRow.Cells["RoomId"].Value;
            using (var db = new AppDbContext())
            {
                var room = db.Rooms.Find(roomId);
                if (room != null)
                {
                    db.Rooms.Remove(room);
                    db.SaveChanges();
                }
            }
            OdswiezListeSal();
            ZaladujComboBoxSale();
        }
    }

    // Obs³uga przycisku "Dodaj rezerwacjê"
    private void buttonDodajRezerwacje_Click(object sender, EventArgs e)
    {
        if (comboBoxSale.SelectedValue == null) return;

        int roomId = (int)comboBoxSale.SelectedValue;
        DateTime startTime = dateTimePickerOd.Value;
        DateTime endTime = dateTimePickerDo.Value;
        string who = textBoxRezerwujacy.Text;

        using (var db = new AppDbContext())
        {
            var reservation = new Reservation
            {
                RoomId = roomId,
                StartTime = startTime,
                EndTime = endTime,
                ReservedBy = who
            };
            db.Reservations.Add(reservation);
            db.SaveChanges();
        }
        OdswiezListeRezerwacji();
    }

    // Obs³uga przycisku "Usuñ rezerwacjê"
    private void buttonUsunRezerwacje_Click(object sender, EventArgs e)
    {
        if (dataGridViewReservations.CurrentRow != null)
        {
            // w DataGridView z rezerwacjami mamy kolumnê ReservationId
            int reservationId = (int)dataGridViewReservations.CurrentRow.Cells["ReservationId"].Value;

            using (var db = new AppDbContext())
            {
                var reservation = db.Reservations.Find(reservationId);
                if (reservation != null)
                {
                    db.Reservations.Remove(reservation);
                    db.SaveChanges();
                }
            }
            OdswiezListeRezerwacji();
        }
    }
}
