using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ExerService
{
    [DataContract]
    public class CalculateBMIResponse : ErrorListResponse
    {
        [DataMember]
        public double BMI { get; set; }
        [DataMember]
        public string Status { get; set; }
    }
}