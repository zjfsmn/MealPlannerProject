using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MealPlanner.Web
{
    public  class Physical
    {
        public  double ConvertWeight(int pounds)
        {
            double kg;
            kg = pounds * 0.45;
            return kg;
        }

        public  double ConvertHeight(int feets, int inches)
        {
            double cm;
            cm = ((feets * 12) + inches) * 2.5;
            return cm;
        }

        public  double BMIcalculation(double kg, double cm)
        {
            double BMI;
           
            
            BMI = kg / Math.Pow(cm / 100.0, 2);
            return BMI;


        }


        public  int GetBmrmult(DTO.Enums.ActivityLevel ExerciseLevel)
        {


            int bmrmult = 0;

            if ((int)ExerciseLevel != -1)
            {
                //string exercise;

                //exercise = ExerciseLevel.ToString();
                switch (ExerciseLevel)

                {
                    case DTO.Enums.ActivityLevel.sedentary:
                        bmrmult = (int)1.2m;
                        break;
                    case DTO.Enums.ActivityLevel.lightlyActive:
                        bmrmult = (int)1.375m;
                        break;
                    case DTO.Enums.ActivityLevel.moderatelyActive:
                        bmrmult = (int)1.55m;
                        break;
                    case DTO.Enums.ActivityLevel.veryActive:
                        bmrmult = (int)1.725m;
                        break;
                    case DTO.Enums.ActivityLevel.extraActive:
                        bmrmult = (int)1.9m;
                        break;
                }


            }

            return bmrmult;

        }

        public  int GetCalories(double height, double weight, int age, DTO.Enums.Gender gender, DTO.Enums.ActivityLevel exerciseLevel)
        {

            double BMR = 0;

            int Calories;
            //select gender
            //if (genderList.SelectedIndex != -1)
            if ((int)gender != -1)
            {
                //string gender = g.ToString();
                switch (gender)
                {
                    case DTO.Enums.Gender.Male:
                        //perform calculation
                        BMR = (weight * 10 + height * 6.25 - age * 5 - 5);

                        break;

                    case DTO.Enums.Gender.Female:
                        BMR = weight * 10 + height * 6.25 - age * 5 - 161;
                        break;

                }
            }


            Calories = Convert.ToInt32(BMR * GetBmrmult(exerciseLevel));
            return Calories;

        }

        
    }
}