using System.ComponentModel.DataAnnotations;

namespace EventManager.Models.Domain
{
    public class Event
    {
        public int Id { get; set; }
        [Required]
        public string? EventCategory { get; set; }

        public string? Year { get; set; } // Updated property name to Year instead of ReleaseYear
        [Required]
        public string? EventImage { get; set; }
        [Required]
        public string? Host { get; set; } // Updated property name to Host instead of Cast
        [Required]
        public string? Organizer { get; set; }
    }
}
