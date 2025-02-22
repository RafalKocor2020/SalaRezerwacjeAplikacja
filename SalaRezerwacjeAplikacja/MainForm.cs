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

    // Gdy formularz si� za�aduje
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
            comboBoxSale.DisplayMember = "Name";  // Wy�wietlamy nazw� sali
            comboBoxSale.ValueMember = "RoomId";  // Pod spodem ID sali
        }
    }

    // Od�wie�a DataGridView z salami
    private void OdswiezListeSal()
    {
        using (var db = new AppDbContext())
        {
            var rooms = db.Rooms.ToList();
            dataGridViewRooms.DataSource = rooms;
        }
    }

    // Od�wie�a DataGridView z rezerwacjami
    private void OdswiezListeRezerwacji()
    {
        using (var db = new AppDbContext())
        {
            // Pobierz rezerwacje wraz z nazw� sali
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

    // Obs�uga przycisku "Dodaj sal�"
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

    // Obs�uga przycisku "Usu� sal�"
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

    // Obs�uga przycisku "Dodaj rezerwacj�"
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

    // Obs�uga przycisku "Usu� rezerwacj�"
    private void buttonUsunRezerwacje_Click(object sender, EventArgs e)
    {
        if (dataGridViewReservations.CurrentRow != null)
        {
            // w DataGridView z rezerwacjami mamy kolumn� ReservationId
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
