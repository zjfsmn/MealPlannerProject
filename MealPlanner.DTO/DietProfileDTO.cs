using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlanner.DTO
{
  public  class DietProfileDTO
    {
        public string UserName { get; set; }
        public MealPlanner.DTO.Enums.DietChoice DietChoice { get; set; }
        public bool Gluten { get; set; }
        public bool Peanut { get; set; }
        public bool Eggs { get; set; }
        public bool Dairy { get; set; }
        public bool Soy { get; set; }
        public bool Onion { get; set; }
        public bool Nuts { get; set; }
        public bool Seafood { get; set; }

    }
}
