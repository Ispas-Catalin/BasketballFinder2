using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BasketballFinder2.Data;
using BasketballFinder2.Models;

namespace BasketballFinder2.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly BasketballFinder2.Data.BasketballFinder2Context _context;

        public IndexModel(BasketballFinder2.Data.BasketballFinder2Context context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
