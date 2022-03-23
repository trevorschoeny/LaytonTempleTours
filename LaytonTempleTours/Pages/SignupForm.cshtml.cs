using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaytonTempleTours.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LaytonTempleTours.Pages
{
    public class SignupFormModel : PageModel
    {
        //private ToursContext context;
        private IAppointmentRepository repoApp { get; set; }
        private ITimeSlotRepository repoTime { get; set; }

        [BindProperty]
        public TimeSlot timeSlot { get; set; }

        [BindProperty]
        public Appointment appointment { get; set; }

        //public SignupFormModel(ToursContext _context)
        //{
        //    context = _context;
        //}

        public SignupFormModel(IAppointmentRepository tempApp, ITimeSlotRepository tempTime)
        {
            repoApp = tempApp;
            repoTime = tempTime;
        }

        //public void OnGet(int id)
        //{
        //    appointment = new Appointment();
        //    timeSlot = context.TimeSlots.Single(x => x.ID == id);
        //}

        public void OnGet(int id)
        {
            timeSlot = repoTime.TimeSlots.Single(x => x.ID == id);
            appointment = new Appointment();
        }

        //public IActionResult OnPost()
        //{
        //    context.Appointments.Add(appointment);
        //    context.Entry(timeSlot).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        //    context.SaveChanges();
            
        //    return RedirectToPage("Index");
        //}

        public IActionResult OnPost(int timeid)
        {
            timeSlot = repoTime.TimeSlots.Single(x => x.ID == timeid);
            repoApp.Create(appointment);
            //repoApp.Save(appointment);
            var a = appointment.ID;
            timeSlot.AppointmentID = a;
            repoTime.Save(timeSlot);
            return RedirectToPage("Index");
        }
    }
}
