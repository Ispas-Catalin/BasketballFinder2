using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BasketballFinder2.Models
{
    public class Appointment
    {
        public int ID { get; set; }

        [Display(Name = "Reserved From")]
        public DateTime Start_date { get; set; }

        [Display(Name = "Reserved Until")]
        public DateTime End_date { get; set; }

        public int LocationID { get; set; }
        public Location Location { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }
    }
}
