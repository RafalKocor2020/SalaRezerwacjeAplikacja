using Microsoft.EntityFrameworkCore;
using SalaRezerwacjeAplikacja.Models;

namespace SalaRezerwacjeAplikacja.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public AppDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Jeśli jeszcze nie skonfigurowano, to używamy SQLite z plikiem 'rezerwacje.db'
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=rezerwacje.db");
            }
        }
    }
}
