using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalaRezerwacjeAplikacja.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }

        public int RoomId { get; set; }
        [ForeignKey("RoomId")]
        public Room Room { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string ReservedBy { get; set; }
    }
}
