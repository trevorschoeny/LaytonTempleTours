using System;
using System.Linq;

namespace LaytonTempleTours.Models
{
    public class EFAppointmentRepository : IAppointmentRepository
    {
        private ToursContext context { get; set; }

        public EFAppointmentRepository(ToursContext temp) => context = temp;

        public IQueryable<Appointment> Appointments => context.Appointments;

        public void Create(Appointment a)
        {
            context.Add(a);
            context.SaveChanges();
        }

        public void Delete(Appointment a)
        {
            context.Remove(a);
            context.SaveChanges();
        }

        public void Save(Appointment a)
        {
            context.SaveChanges();
        }
    }
}
