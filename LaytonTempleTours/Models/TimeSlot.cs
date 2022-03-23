using System;
using System.ComponentModel.DataAnnotations;

namespace LaytonTempleTours.Models
{
    public class TimeSlot
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        public int? AppointmentID { get; set; }

        // Navigation Properties
        //public Appointment Appointment { get; set; }
    }
}
