using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlanner.Persistence
{
   public class DietProfileRepository
    {
        public static void CreateDietProfiles(DTO.DietProfileDTO dietProfileDTO)
        {
            var db = new MealPlannerDbEntities();
            var dietProfile = convertToEntity(dietProfileDTO);


            db.DietProfiles.Add(dietProfile);
            db.SaveChanges();

        }

        private static DietProfile convertToEntity(DTO.DietProfileDTO dietProfileDTO)
        {
            var dietProfile = new DietProfile();

            dietProfile.UserName = dietProfileDTO.UserName;
            dietProfile.DietChoice = dietProfileDTO.DietChoice;
            dietProfile.Gluten = dietProfileDTO.Gluten;
            dietProfile.Nuts = dietProfileDTO.Nuts;
            dietProfile.Eggs = dietProfileDTO.Eggs;
            dietProfile.Peanut = dietProfileDTO.Peanut;
            dietProfile.Dairy = dietProfileDTO.Dairy;
            dietProfile.Soy = dietProfileDTO.Soy;
            dietProfile.Seafood = dietProfileDTO.Seafood;
            dietProfile.Onion = dietProfileDTO.Onion;
          

            return dietProfile;

        }
    }
}
