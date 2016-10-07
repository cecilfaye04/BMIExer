using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ExerService
{
    [ServiceContract]
    public interface IBMIService1
    {
        [OperationContract]
        HeightResponse ConvertCmToFeet(HeightRequest cm);
        [OperationContract]
        HeightResponse ConvertFeetToCm(HeightRequest ft);
        [OperationContract]
        WeightResponse ConvertKgtoLbs(WeightRequest kg);
        [OperationContract]
        WeightResponse ConvertLbsToKgs(WeightRequest lbs);
        [OperationContract]
        CalculateBMIResponse CalculateBMI(CalculateBMIRequest bmi);

    }

    
}
