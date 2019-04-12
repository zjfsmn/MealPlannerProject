using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MealPlanner.Web
{
    public partial class PhysicalProfile : System.Web.UI.Page
    {
        Physical physical = new Physical();



        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void calculate_button_Click(object sender, EventArgs e)
        {
            //The purpose is to check the Click event code block. 
            //If it returns false (the data is not valid) the flow of code will exit the Click event so as to prevent the submit from being created
            if (!TextBoxDataIsValid())
            {
                return;
            }

            var physicalProfileDTO = buildPhysicalProfile();

            Domain.PhysicalProfileManager.CreatePhysicalProfiles(physicalProfileDTO);
        }

        // get user input from server controls
        private DTO.PhysicalProfileDTO buildPhysicalProfile()
        {
            DTO.PhysicalProfileDTO physicalProfileDTO = new DTO.PhysicalProfileDTO();


            physicalProfileDTO.UserName = Session["userName"].ToString();
            physicalProfileDTO.DoOption = determineDoOption();
            physicalProfileDTO.Gender = determineGender();
            physicalProfileDTO.Height = physical.ConvertHeight((Convert.ToInt32(txbheightfeet.Text)), Convert.ToInt32(txbheightinch.Text));//store the height in database in cm, need to convert to cm before storing into database
            physicalProfileDTO.Weight = physical.ConvertWeight(Convert.ToInt32(txbWeight.Text)); //store the weight in database in kg, need to convert to kg before storing into database
            physicalProfileDTO.Age = Convert.ToInt32(txbAge.Text);
            physicalProfileDTO.ActivityLevel = determineActivityLevel();
            physicalProfileDTO.FinalWeight = Convert.ToInt32(tbxGoalWeight.Text);
            physicalProfileDTO.DaysToGo = Convert.ToInt32(tbxDaysToGo.Text);

            physicalProfileDTO.BMI = physical.BMIcalculation( physicalProfileDTO.Weight, physicalProfileDTO.Height);
            LabelMBI.Text = physicalProfileDTO.BMI.ToString();

            physicalProfileDTO.SuggestedCalories = physical.GetCalories(physicalProfileDTO.Height, physicalProfileDTO.Weight, physicalProfileDTO.Age, physicalProfileDTO.Gender, physicalProfileDTO.ActivityLevel);
            LabelSuggestCalories.Text = physicalProfileDTO.SuggestedCalories.ToString();

            return physicalProfileDTO;
        }



        // get user's activity level
        private DTO.Enums.ActivityLevel determineActivityLevel()
        {
            DTO.Enums.ActivityLevel activity;
            if (!Enum.TryParse(DDLExercise.SelectedValue, out activity))
            {
                throw new Exception("You should select your activity level!");
            }
            return activity;
        }


        //get what the user want to do
        private DTO.Enums.DoOption determineDoOption()
        {
            DTO.Enums.DoOption doOption;
            if (RadioButtonLoseWeight.Checked)
            {
                doOption = DTO.Enums.DoOption.LoseWeight;

            }
            else 
                doOption = DTO.Enums.DoOption.Maintain;

            return doOption;
        }


        private DTO.Enums.Gender determineGender()
        {
            DTO.Enums.Gender gender;
            if (RadioButtonFemale.Checked)
            {
                gender = DTO.Enums.Gender.Female;
            }
            else
                gender = DTO.Enums.Gender.Male;

            return gender;

        }
       
        
        //we'll need to ensure that the user input value into all of the TextBoxes that is not null in database.
        // If any of the TextBoxes are left empty, we need to provide the user, not with an exception, but with an error message describing what they need to fix to submit this form. 
        //This method will take in a string from the caller that will be used in the error message to tell which TextBox is invalid. 
        //Then, it sets the validationLabel's text to the error message and makes it visible:
        private void textBoxValidationError(string errorType)
        {
            string errorMessage = "";
            errorMessage += string.Format("<strong> Please enter a {0}. </strong>", errorType);
            validationLabel.Text = errorMessage;
            validationLabel.Visible = true;
        }

        // to find out which textbox is not valid
        private bool TextBoxDataIsValid()
        {
            if (txbheightfeet.Text.Trim().Length == 0)
            {
                textBoxValidationError("feet of height");
                return false;
            }
            else if (txbheightinch.Text.Trim().Length == 0)
            {
                textBoxValidationError("inch of height");
                return false;
            }
            else if (txbWeight.Text.Trim().Length == 0)
            {
                textBoxValidationError("weight");
                return false;
            }

            else if (txbAge.Text.Trim().Length == 0)
            {
                textBoxValidationError("age");
                return false;
            }
            else
                return true;
        }

       

    }
}