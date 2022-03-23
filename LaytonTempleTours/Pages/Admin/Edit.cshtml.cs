using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaytonTempleTours.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LaytonTempleTours.Pages.Admin
{
    public class EditModel : PageModel
    {
        private ToursContext db;

        [BindProperty]
        public Appointment appointment { get; set; }

        public EditModel(ToursContext _db)
        {
            db = _db;
        }
        public void OnGet(int id)
        {
            appointment = db.Appointments.Find(id);
        }

        public IActionResult OnPost(int appid)
        {
            appointment.ID = appid;
            db.Entry(appointment).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
