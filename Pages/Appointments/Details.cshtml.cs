using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BasketballFinder2.Data;
using BasketballFinder2.Models;

namespace BasketballFinder2.Pages.Appointments
{
    public class DetailsModel : PageModel
    {
        private readonly BasketballFinder2.Data.BasketballFinder2Context _context;

        public DetailsModel(BasketballFinder2.Data.BasketballFinder2Context context)
        {
            _context = context;
        }

        public Appointment Appointment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Appointment = await _context.Appointment
                .Include(a => a.Location)
                .Include(a => a.User)
                .FirstOrDefaultAsync(m => m.ID == id);

            if (Appointment == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
