using System;
using System.Linq;

namespace LaytonTempleTours.Models
{
    public class EFTimeSlotRepository : ITimeSlotRepository
    {
        private ToursContext context { get; set; }

        public EFTimeSlotRepository(ToursContext temp) => context = temp;

        public IQueryable<TimeSlot> TimeSlots => context.TimeSlots;

    }
}
