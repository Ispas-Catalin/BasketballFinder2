using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BasketballFinder2.Data;
using BasketballFinder2.Models;

namespace BasketballFinder2.Pages.Appointments
{
    public class CreateModel : PageModel
    {
        private readonly BasketballFinder2.Data.BasketballFinder2Context _context;

        public CreateModel(BasketballFinder2.Data.BasketballFinder2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["UserID"] = new SelectList(_context.Set<User>(), "ID", "Username");
            ViewData["LocationID"] = new SelectList(_context.Set<Location>(), "ID", "Name");
            return Page();
        }

        [BindProperty]
        public Appointment Appointment { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Appointment.Add(Appointment);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
