using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BasketballFinder2.Models
{
    public class Location
    {
        public int ID { get; set; }

        [Display(Name = "Location")]
        public string Name { get; set; }
        public string Address { get; set; }
        public int Capacity { get; set; }
    }
}
