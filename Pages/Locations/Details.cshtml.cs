using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BasketballFinder2.Data;
using BasketballFinder2.Models;

namespace BasketballFinder2.Pages.Locations
{
    public class DetailsModel : PageModel
    {
        private readonly BasketballFinder2.Data.BasketballFinder2Context _context;

        public DetailsModel(BasketballFinder2.Data.BasketballFinder2Context context)
        {
            _context = context;
        }

        public Location Location { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Location = await _context.Location.FirstOrDefaultAsync(m => m.ID == id);

            if (Location == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
