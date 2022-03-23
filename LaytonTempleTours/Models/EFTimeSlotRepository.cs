using System;
using System.Linq;

namespace LaytonTempleTours.Models
{
    public class EFTimeSlotRepository : ITimeSlotRepository
    {
        private ToursContext context { get; set; }

        public EFTimeSlotRepository(ToursContext temp) => context = temp;

        public IQueryable<TimeSlot> TimeSlots => context.TimeSlots;

        public void Create(TimeSlot t)
        {
            context.Add(t);
            context.SaveChanges();
        }

        public void Delete(TimeSlot t)
        {
            context.Remove(t);
            context.SaveChanges();
        }

        public void Save(TimeSlot t)
        {
            context.SaveChanges();
        }

    }
}

//