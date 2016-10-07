using MvcWCFExer.BMIService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcWCFExer
{
    public class Manager
    {

        BMIService1Client bmService = new BMIService1Client();
        HeightResponse convertedHeight;
        WeightResponse convertedWeight;
        CalculateBMIResponse calculatedBmi;

        public HeightResponse ConvertFtToCm(HeightRequest ft)
        {
            convertedHeight = bmService.ConvertFeetToCm(ft);
            return convertedHeight;
        }

        public HeightResponse ConvertCmToFt(HeightRequest cm)
        {
            convertedHeight = bmService.ConvertCmToFeet(cm);
            return convertedHeight;
        }

        public WeightResponse ConvertKgToLb(WeightRequest kg)
        {
            convertedWeight = bmService.ConvertKgtoLbs(kg);
            return convertedWeight;
        }

        public WeightResponse ConvertLbToKg(WeightRequest lb)
        {
            convertedWeight = bmService.ConvertLbsToKgs(lb);
            return convertedWeight;
        }
        public CalculateBMIResponse CalculateBMI(CalculateBMIRequest bmi)
        {
            calculatedBmi = bmService.CalculateBMI(bmi);
            return calculatedBmi;
        }
    }
}