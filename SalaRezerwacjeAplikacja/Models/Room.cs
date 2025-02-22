using System.ComponentModel.DataAnnotations;

namespace SalaRezerwacjeAplikacja.Models
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
    }
}
