using System;
using System.Linq;

namespace LaytonTempleTours.Models
{
    public interface ITimeSlotRepository
    {
        IQueryable<TimeSlot> TimeSlots { get; }

        public void Save(TimeSlot t);
        public void Create(TimeSlot t);
        public void Delete(TimeSlot t);
    }
}
