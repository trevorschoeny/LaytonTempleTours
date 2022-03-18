using System;
using System.Linq;

namespace LaytonTempleTours.Models
{
    public interface IAppointmentRepository
    {
        IQueryable<Appointment> Appointments { get; }

        public void Save(Appointment a);
        public void Create(Appointment a);
        public void Delete(Appointment a);
    }
}
