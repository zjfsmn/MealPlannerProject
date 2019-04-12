using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MealPlanner.DTO;

namespace MealPlanner.Persistence
{
    public class MealPlannerRepository
    {
        public static void CreateUser(DTO.MealPlannerDTO mealPlannerDTO)
        {
            var db = new MealPlannerDbEntities();
            var user = convertToEntity(mealPlannerDTO);

            db.Users.Add(user);
            db.SaveChanges();

        }

        private static User convertToEntity(MealPlannerDTO mealPlannerDTO)
        {
            var user = new User();

           
            user.UserName = mealPlannerDTO.UserName;
            user.Email = mealPlannerDTO.Email;
            user.Password = mealPlannerDTO.Password;

            return user;
        }
    }
}
