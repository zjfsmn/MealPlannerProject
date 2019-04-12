using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlanner.Domain
{
    public class MealPlannerManager
    {
        public static void CreateUser(DTO.MealPlannerDTO mealPlannerDTO)
        {
     
            
            Persistence.MealPlannerRepository.CreateUser(mealPlannerDTO);

        }
       
    }
}
