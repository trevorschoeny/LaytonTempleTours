using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace LaytonTempleTours.Models
{
    public class Appointment
    {
        [Key]
        [BindNever]
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter a Name for the Group")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the Size of the Group")]
        [Range(1, 15, ErrorMessage = "Group Size must be up to 15 Persons")]
        public int Size { get; set; }

        [Required(ErrorMessage = "Please enter an Email Address")]
        public string Email { get; set; }

        public string Phone { get; set; }

        [Required]
        public DateTime Time { get; set; }

        // Navigation Property
        //public TimeSlot TimeSlot { get; set; }

    }
}
