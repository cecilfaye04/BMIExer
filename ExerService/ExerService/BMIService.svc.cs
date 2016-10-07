using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ExerService
{
    public class BMIService : IBMIService1
    {

        BMIManager bmiMgr = new BMIManager();
        HeightResponse convertedHeight;
        WeightResponse convertedWeight;
        CalculateBMIResponse bmiResult;

        HeightResponse IBMIService1.ConvertCmToFeet(HeightRequest cm)
        {
            convertedHeight = new HeightResponse();
            bmiMgr.ValidationInput(cm.Height,convertedHeight.errorList);
            double ft = bmiMgr.ConvertCmToFeet(cm.Height);
            convertedHeight.Height = ft;
            return convertedHeight;
        }

        HeightResponse IBMIService1.ConvertFeetToCm(HeightRequest ft)
        {
            convertedHeight = new HeightResponse();
            bmiMgr.ValidationInput(ft.Height, convertedHeight.errorList);
            double cm = bmiMgr.ConvertFeetToCm(ft.Height);
            convertedHeight.Height = cm;
            return convertedHeight;
        }

        WeightResponse IBMIService1.ConvertKgtoLbs(WeightRequest kg)
        {
            convertedWeight = new WeightResponse();
            bmiMgr.ValidationInput(kg.Weight, convertedWeight.errorList);
            double lbs = bmiMgr.ConvertKgtoLbs(kg.Weight);
            convertedWeight.Weight = lbs;
            return convertedWeight;
        }
        WeightResponse IBMIService1.ConvertLbsToKgs(WeightRequest lbs)
        {
            convertedWeight = new WeightResponse();
            bmiMgr.ValidationInput(lbs.Weight, convertedWeight.errorList);
            double kg = bmiMgr.ConvertLbsToKgs(lbs.Weight);
            convertedWeight.Weight = kg;
            return convertedWeight;
        }
        CalculateBMIResponse IBMIService1.CalculateBMI(CalculateBMIRequest bmi)
        {
            bmiResult = new CalculateBMIResponse();
            bmiMgr.ValidationInput(bmi.Weight, bmiResult.errorList);
            bmiMgr.ValidationInput(bmi.Height, bmiResult.errorList);
            double result = bmiMgr.CalculateBMI(bmi.Height, bmi.Weight);
            string status = bmiMgr.BMIStatus(result);
            bmiResult.BMI = result;
            bmiResult.Status = status;
            return bmiResult;
        }

    }
}
