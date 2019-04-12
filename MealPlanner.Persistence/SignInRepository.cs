using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlanner.Persistence
{
    public class SignInRepository
    {
        public static List<DTO.MealPlannerDTO> GetUser()
        {
            var db = new MealPlannerDbEntities();
            var users = db.Users.ToList();

            var usersDTO = convertToDTO(users);
            return usersDTO;
        }

        public static List<DTO.MealPlannerDTO> convertToDTO(List<User> users)
        {
            var usersDTO = new List<DTO.MealPlannerDTO>();
            foreach(var user in users)
            {
                var userDTO = new DTO.MealPlannerDTO();
                userDTO.UserName = user.UserName;
                userDTO.Password = user.Password;
                //userDTO.Email = user.Email;

                usersDTO.Add(userDTO);

            }

            return usersDTO;
        }
    }
}
