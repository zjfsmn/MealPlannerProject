using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlanner.Domain
{
   public class DietProfileManager
    {
        public static void CreateDietProfiles(DTO.DietProfileDTO dietProfileDTO)
        {

            Persistence.DietProfileRepository.CreateDietProfiles(dietProfileDTO);

        }
    }
}
