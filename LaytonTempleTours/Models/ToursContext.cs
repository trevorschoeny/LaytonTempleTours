using System;
using Microsoft.EntityFrameworkCore;

namespace LaytonTempleTours.Models
{
    public class ToursContext : DbContext
    {
        public ToursContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<TimeSlot> TimeSlots { get; set; }
    }
}
