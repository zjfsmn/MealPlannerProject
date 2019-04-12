using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlanner.Domain
{
   public class PhysicalProfileManager
    {
        public static void CreatePhysicalProfiles(DTO.PhysicalProfileDTO physicalProfileDTO)
        {
            
            Persistence.PhysicalProfileRepository.CreatePhysicalProfiles(physicalProfileDTO);
            
        }

    }
}
