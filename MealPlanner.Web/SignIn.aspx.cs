using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MealPlanner.Web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void signInButton_Click(object sender, EventArgs e)
        {
            MealPlanner.DTO.MealPlannerDTO mealPlannerDTO = new DTO.MealPlannerDTO();

            mealPlannerDTO.UserName = UserNameSigninTextBox.Text;

            mealPlannerDTO.Password = PasswordSigninTextBox.Text;




            string result = "";

            result = Domain.SignInManager.SignInResult(mealPlannerDTO);


            resultLabel.Text = result;
        }

        protected void forgotpasswordButton_Click(object sender, EventArgs e)
        {

        }

       
    }
}