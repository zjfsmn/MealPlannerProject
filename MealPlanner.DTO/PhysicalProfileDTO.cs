using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MealPlanner.Persistence;

namespace MealPlanner.DTO
{
   public class PhysicalProfileDTO
    {
        public MealPlanner.DTO.Enums.DoOption DoOption { get; set; }
        public MealPlanner.DTO.Enums.Gender Gender { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }
        public MealPlanner.DTO.Enums.ActivityLevel ActivityLevel { get; set; }
        public Nullable<double> FinalWeight { get; set; }
        public Nullable<int> DaysToGo { get; set; }
        public string UserName { get; set; }
        public Nullable<double> BMI { get; set; }
        public Nullable<int> SuggestedCalories { get; set; }
    }
}
