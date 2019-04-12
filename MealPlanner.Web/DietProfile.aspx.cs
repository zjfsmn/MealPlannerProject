using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MealPlanner.Web
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }
        protected void BtnDietSubmit_Click(object sender, EventArgs e)
        {
            var dietProfileDTO = buildDietProfile();
            Domain.DietProfileManager.CreateDietProfiles(dietProfileDTO);
        }

        private DTO.DietProfileDTO buildDietProfile()
        {
            DTO.DietProfileDTO dietProfileDTO = new DTO.DietProfileDTO();
            dietProfileDTO.UserName = Session["userName"].ToString();
            dietProfileDTO.DietChoice = determineDietChoice();
            dietProfileDTO.Gluten = GlutenCheckBox.Checked;
            dietProfileDTO.Eggs = EggsCheckBox.Checked;
            dietProfileDTO.Dairy = DairyCheckBox.Checked;
            dietProfileDTO.Nuts = NutsCheckBox.Checked;
            dietProfileDTO.Onion = OnionCheckBox.Checked;
            dietProfileDTO.Seafood = SeafoodCheckBox.Checked;
            dietProfileDTO.Peanut = PeanutCheckBox.Checked;
            dietProfileDTO.Soy = SoyCheckBox.Checked;


            return dietProfileDTO;
        }

        // get user's diet choice and pass to DTO object
        private DTO.Enums.DietChoice determineDietChoice()
        {
            DTO.Enums.DietChoice dietChoice;
            if (RadioButtonAnything.Checked)
            {
                dietChoice = DTO.Enums.DietChoice.Anything;
            }
            else
                dietChoice = DTO.Enums.DietChoice.Vegan;

            return dietChoice;
        }


        // get which checkbox is checked.
        //private void getCheckBoxList()
        //{
        //    DTO.DietProfileDTO dietProfileDTO = new DTO.DietProfileDTO();
        //    if (CheckBoxListAllergies.SelectedItem != null)
        //    {
        //        switch (CheckBoxListAllergies.SelectedValue)
        //        {
        //            case "Gluten":
        //                dietProfileDTO.Gluten = true;
        //                break;
        //            case "Peanut":
        //                dietProfileDTO.Peanut = true;
        //                break;
        //            case "Eggs":
        //                dietProfileDTO.Eggs = true;
        //                break;
        //            case "Dairy":
        //                dietProfileDTO.Dairy = true;
        //                break;
        //            case "Soy":
        //                dietProfileDTO.Soy = true;
        //                break;
        //            case "Onion":
        //                dietProfileDTO.Onion = true;
        //                break;
        //            case "Nuts":
        //                dietProfileDTO.Nuts = true;
        //                break;
        //            case "Seafood":
        //                dietProfileDTO.Seafood = true;
        //                break;


        //        }
        //    }
        //}






}
}