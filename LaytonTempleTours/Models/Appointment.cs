using System;
using System.ComponentModel.DataAnnotations;

namespace LaytonTempleTours.Models
{
    public class Appointment
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Size { get; set; }
        [Required]
        public string Email { get; set; }
        public string Phone { get; set; }

        // Navigation Property
        public TimeSlot TimeSlot { get; set; }

    }
}
