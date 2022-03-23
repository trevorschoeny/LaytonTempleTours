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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<TimeSlot>().HasData(
                new TimeSlot
                {
                    ID = 1,
                    DateTime = new DateTime(2022, 4, 4, 8, 0, 0)
                },
                new TimeSlot
                {
                    ID = 2,
                    DateTime = new DateTime(2022, 4, 4, 9, 0, 0)
                },
                new TimeSlot
                {
                    ID = 3,
                    DateTime = new DateTime(2022, 4, 4, 10, 0, 0)
                },
                new TimeSlot
                {
                    ID = 4,
                    DateTime = new DateTime(2022, 4, 4, 11, 0, 0)
                },
                new TimeSlot
                {
                    ID = 5,
                    DateTime = new DateTime(2022, 4, 4, 12, 0, 0)
                },
                new TimeSlot
                {
                    ID = 6,
                    DateTime = new DateTime(2022, 4, 4, 13, 0, 0)
                },
                new TimeSlot
                {
                    ID = 7,
                    DateTime = new DateTime(2022, 4, 4, 14, 0, 0)
                },
                new TimeSlot
                {
                    ID = 8,
                    DateTime = new DateTime(2022, 4, 4, 15, 0, 0)
                },
                new TimeSlot
                {
                    ID = 9,
                    DateTime = new DateTime(2022, 4, 4, 16, 0, 0)
                },
                new TimeSlot
                {
                    ID = 10,
                    DateTime = new DateTime(2022, 4, 4, 17, 0, 0)
                },
                new TimeSlot
                {
                    ID = 11,
                    DateTime = new DateTime(2022, 4, 4, 18, 0, 0)
                },
                new TimeSlot
                {
                    ID = 12,
                    DateTime = new DateTime(2022, 4, 4, 19, 0, 0)
                },
                new TimeSlot
                {
                    ID = 13,
                    DateTime = new DateTime(2022, 4, 5, 8, 0, 0)
                },
                new TimeSlot
                {
                    ID = 14,
                    DateTime = new DateTime(2022, 4, 5, 9, 0, 0)
                },
                new TimeSlot
                {
                    ID = 15,
                    DateTime = new DateTime(2022, 4, 5, 10, 0, 0)
                },
                new TimeSlot
                {
                    ID = 16,
                    DateTime = new DateTime(2022, 4, 5, 11, 0, 0)
                },
                new TimeSlot
                {
                    ID = 17,
                    DateTime = new DateTime(2022, 4, 5, 12, 0, 0)
                },
                new TimeSlot
                {
                    ID = 18,
                    DateTime = new DateTime(2022, 4, 5, 13, 0, 0)
                },
                new TimeSlot
                {
                    ID = 19,
                    DateTime = new DateTime(2022, 4, 5, 14, 0, 0)
                },
                new TimeSlot
                {
                    ID = 20,
                    DateTime = new DateTime(2022, 4, 5, 15, 0, 0)
                },
                new TimeSlot
                {
                    ID = 21,
                    DateTime = new DateTime(2022, 4, 5, 16, 0, 0)
                },
                new TimeSlot
                {
                    ID = 22,
                    DateTime = new DateTime(2022, 4, 5, 17, 0, 0)
                },
                new TimeSlot
                {
                    ID = 23,
                    DateTime = new DateTime(2022, 4, 5, 18, 0, 0)
                },
                new TimeSlot
                {
                    ID = 24,
                    DateTime = new DateTime(2022, 4, 5, 19, 0, 0)
                },
                new TimeSlot
                {
                    ID = 25,
                    DateTime = new DateTime(2022, 4, 6, 8, 0, 0)
                },
                new TimeSlot
                {
                    ID = 26,
                    DateTime = new DateTime(2022, 4, 6, 9, 0, 0)
                },
                new TimeSlot
                {
                    ID = 27,
                    DateTime = new DateTime(2022, 4, 6, 10, 0, 0)
                },
                new TimeSlot
                {
                    ID = 28,
                    DateTime = new DateTime(2022, 4, 6, 11, 0, 0)
                },
                new TimeSlot
                {
                    ID = 29,
                    DateTime = new DateTime(2022, 4, 6, 12, 0, 0)
                },
                new TimeSlot
                {
                    ID = 30,
                    DateTime = new DateTime(2022, 4, 6, 13, 0, 0)
                },
                new TimeSlot
                {
                    ID = 31,
                    DateTime = new DateTime(2022, 4, 6, 14, 0, 0)
                },
                new TimeSlot
                {
                    ID = 32,
                    DateTime = new DateTime(2022, 4, 6, 15, 0, 0)
                },
                new TimeSlot
                {
                    ID = 33,
                    DateTime = new DateTime(2022, 4, 6, 16, 0, 0)
                },
                new TimeSlot
                {
                    ID = 34,
                    DateTime = new DateTime(2022, 4, 6, 17, 0, 0)
                },
                new TimeSlot
                {
                    ID = 35,
                    DateTime = new DateTime(2022, 4, 6, 18, 0, 0)
                },
                new TimeSlot
                {
                    ID = 36,
                    DateTime = new DateTime(2022, 4, 6, 19, 0, 0)
                },
                new TimeSlot
                {
                    ID = 37,
                    DateTime = new DateTime(2022, 4, 7, 8, 0, 0)
                },
                new TimeSlot
                {
                    ID = 38,
                    DateTime = new DateTime(2022, 4, 7, 9, 0, 0)
                },
                new TimeSlot
                {
                    ID = 39,
                    DateTime = new DateTime(2022, 4, 7, 10, 0, 0)
                },
                new TimeSlot
                {
                    ID = 40,
                    DateTime = new DateTime(2022, 4, 7, 11, 0, 0)
                },
                new TimeSlot
                {
                    ID = 41,
                    DateTime = new DateTime(2022, 4, 7, 12, 0, 0)
                },
                new TimeSlot
                {
                    ID = 42,
                    DateTime = new DateTime(2022, 4, 7, 13, 0, 0)
                },
                new TimeSlot
                {
                    ID = 43,
                    DateTime = new DateTime(2022, 4, 7, 14, 0, 0)
                },
                new TimeSlot
                {
                    ID = 44,
                    DateTime = new DateTime(2022, 4, 7, 15, 0, 0)
                },
                new TimeSlot
                {
                    ID = 45,
                    DateTime = new DateTime(2022, 4, 7, 16, 0, 0)
                },
                new TimeSlot
                {
                    ID = 46,
                    DateTime = new DateTime(2022, 4, 7, 17, 0, 0)
                },
                new TimeSlot
                {
                    ID = 47,
                    DateTime = new DateTime(2022, 4, 7, 18, 0, 0)
                },
                new TimeSlot
                {
                    ID = 48,
                    DateTime = new DateTime(2022, 4, 7, 19, 0, 0)
                },
                new TimeSlot
                {
                    ID = 49,
                    DateTime = new DateTime(2022, 4, 8, 8, 0, 0)
                },
                new TimeSlot
                {
                    ID = 50,
                    DateTime = new DateTime(2022, 4, 8, 9, 0, 0)
                },
                new TimeSlot
                {
                    ID = 51,
                    DateTime = new DateTime(2022, 4, 8, 10, 0, 0)
                },
                new TimeSlot
                {
                    ID = 52,
                    DateTime = new DateTime(2022, 4, 8, 11, 0, 0)
                },
                new TimeSlot
                {
                    ID = 53,
                    DateTime = new DateTime(2022, 4, 8, 12, 0, 0)
                },
                new TimeSlot
                {
                    ID = 54,
                    DateTime = new DateTime(2022, 4, 8, 13, 0, 0)
                },
                new TimeSlot
                {
                    ID = 55,
                    DateTime = new DateTime(2022, 4, 8, 14, 0, 0)
                },
                new TimeSlot
                {
                    ID = 56,
                    DateTime = new DateTime(2022, 4, 8, 15, 0, 0)
                },
                new TimeSlot
                {
                    ID = 57,
                    DateTime = new DateTime(2022, 4, 8, 16, 0, 0)
                },
                new TimeSlot
                {
                    ID = 58,
                    DateTime = new DateTime(2022, 4, 8, 17, 0, 0)
                },
                new TimeSlot
                {
                    ID = 59,
                    DateTime = new DateTime(2022, 4, 8, 18, 0, 0)
                },
                new TimeSlot
                {
                    ID = 60,
                    DateTime = new DateTime(2022, 4, 8, 19, 0, 0)
                },
                new TimeSlot
                {
                    ID = 61,
                    DateTime = new DateTime(2022, 4, 9, 8, 0, 0)
                },
                new TimeSlot
                {
                    ID = 62,
                    DateTime = new DateTime(2022, 4, 9, 9, 0, 0)
                },
                new TimeSlot
                {
                    ID = 63,
                    DateTime = new DateTime(2022, 4, 9, 10, 0, 0)
                },
                new TimeSlot
                {
                    ID = 64,
                    DateTime = new DateTime(2022, 4, 9, 11, 0, 0)
                },
                new TimeSlot
                {
                    ID = 65,
                    DateTime = new DateTime(2022, 4, 9, 12, 0, 0)
                },
                new TimeSlot
                {
                    ID = 66,
                    DateTime = new DateTime(2022, 4, 9, 13, 0, 0)
                },
                new TimeSlot
                {
                    ID = 67,
                    DateTime = new DateTime(2022, 4, 9, 14, 0, 0)
                },
                new TimeSlot
                {
                    ID = 68,
                    DateTime = new DateTime(2022, 4, 9, 15, 0, 0)
                },
                new TimeSlot
                {
                    ID = 69,
                    DateTime = new DateTime(2022, 4, 9, 16, 0, 0)
                },
                new TimeSlot
                {
                    ID = 70,
                    DateTime = new DateTime(2022, 4, 9, 17, 0, 0)
                },
                new TimeSlot
                {
                    ID = 71,
                    DateTime = new DateTime(2022, 4, 9, 18, 0, 0)
                },
                new TimeSlot
                {
                    ID = 72,
                    DateTime = new DateTime(2022, 4, 9, 19, 0, 0)
                }
            );
        }
    }
}
