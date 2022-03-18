using System;
using System.Linq;

namespace LaytonTempleTours.Models
{
    public interface ITimeSlotRepository
    {
        IQueryable<TimeSlot> TimeSlots { get; }
    }
}
