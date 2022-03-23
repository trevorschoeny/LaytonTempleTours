using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaytonTempleTours.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LaytonTempleTours.Pages.Admin
{
    public class editModel : PageModel
    {
        private ToursContext db;

        [BindProperty]
        public Appointment appointment { get; set; }

        public editModel(ToursContext _db)
        {
            db = _db;
        }
        public void OnGet(string id)
        {
            appointment = db.Appointments.Find(id);
        }

        public IActionResult OnPost()
        {
            db.Entry(appointment).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
