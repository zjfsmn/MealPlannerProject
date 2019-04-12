using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlanner.Persistence
{
  public   class PhysicalProfileRepository
    {
        public static void CreatePhysicalProfiles(DTO.PhysicalProfileDTO physicalProfileDTO)
        {
            var db = new MealPlannerDbEntities();
            var physicalProfile = convertToEntity(physicalProfileDTO);

            db.PhysicalProfiles.Add(physicalProfile);
            db.SaveChanges();

        }

        private static PhysicalProfile convertToEntity(DTO.PhysicalProfileDTO physicalProfileDTO)
        {
            var physicalProfile = new PhysicalProfile();

            physicalProfile.UserName = physicalProfileDTO.UserName;
            physicalProfile.DoOption = physicalProfileDTO.DoOption;
            physicalProfile.Gender = physicalProfileDTO.Gender;
            physicalProfile.Height = physicalProfileDTO.Height;
            physicalProfile.Weight = physicalProfileDTO.Weight;
            physicalProfile.Age = physicalProfileDTO.Age;
            physicalProfile.ActivityLevel = physicalProfileDTO.ActivityLevel;
            physicalProfile.FinalWeight = physicalProfileDTO.FinalWeight;
            physicalProfile.DaysToGo = physicalProfileDTO.DaysToGo;
            physicalProfile.BMI = physicalProfileDTO.BMI;
            physicalProfile.SuggestedCalories = physicalProfileDTO.SuggestedCalories;
            

            return physicalProfile;

        }
    }
}
