using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BasketballFinder2.Models;

namespace BasketballFinder2.Data
{
    public class BasketballFinder2Context : DbContext
    {
        public BasketballFinder2Context (DbContextOptions<BasketballFinder2Context> options)
            : base(options)
        {
        }

        public DbSet<BasketballFinder2.Models.Appointment> Appointment { get; set; }

        public DbSet<BasketballFinder2.Models.Location> Location { get; set; }

        public DbSet<BasketballFinder2.Models.User> User { get; set; }
    }
}
