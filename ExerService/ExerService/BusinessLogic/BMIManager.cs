using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace ExerService
{
    public class BMIManager
    {
        public double ConvertCmToFeet(double cm)
        {
            double ft = cm * 0.032808;
            return Math.Round(ft, 2);
        }

        public double ConvertFeetToCm(double ft)
        {
            double cm = ft / 0.032808;
            return Math.Round(cm, 2);
        }

        public double ConvertKgtoLbs(double kg)
        {
            double lbs = kg * 2.2046;
            return Math.Round(lbs, 2);
        }

        public double ConvertLbsToKgs(double lbs)
        {
            double kg = lbs / 2.2046;
            return Math.Round(kg, 2);
        }

        public double CalculateBMI(double height, double weight)
        {
            double bmiResult = weight / Math.Pow((height / 100), 2);
            return Math.Round(bmiResult, 2);
        }

        public string BMIStatus(double bmi)
        {
            string status = string.Empty;

            if (bmi < 18.5)
            {
                status = "Underweight";
            }
            else if (bmi > 18.5 && bmi < 24.9)
            {
                status = "Normal";
            }
            else if (bmi > 25.0 && bmi < 29.9)
            {
                status = "Overweight";
            }
            else
            {
                status = "Obese";
            }
            return status;
        }
 

    public void ValidationInput(double inputUnderTest, List<String> errorList)
    {
        if (!Regex.IsMatch(inputUnderTest.ToString(), @"^[a-zA-Z]+$") || inputUnderTest.ToString() == null)
        {
            errorList.Add("Invalid Input!");
        }
    }
}
}