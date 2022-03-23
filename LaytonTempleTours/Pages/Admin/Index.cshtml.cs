using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaytonTempleTours.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LaytonTempleTours.Pages.Admin
{
    public class IndexModel : PageModel
    {
        private ToursContext db;
        public IndexModel(ToursContext _db)
        {
            db = _db;
        }

        public List<Appointment> Appointments;
        public void OnGet()
        {
            Appointments = db.Appointments.ToList();
        }

        public IActionResult OnGetDelete(int id)
        {
            var timeSlot = db.TimeSlots.Single(x => x.AppointmentID == id);
            timeSlot.AppointmentID = null;
            var appointment = db.Appointments.Find(id);
            db.Remove(appointment);
            db.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
