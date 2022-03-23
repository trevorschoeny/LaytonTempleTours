using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaytonTempleTours.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LaytonTempleTours.Pages
{
    public class SignupModel : PageModel
    {
        private ToursContext context;

        public SignupModel(ToursContext _context)
        {
            context = _context;
        }

        public List<TimeSlot> TimeSlots;

        public void OnGet()
        {
            TimeSlots = context.TimeSlots.ToList();
        }
    }
}
