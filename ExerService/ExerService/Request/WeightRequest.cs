using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ExerService
{
    [DataContract]
    public class WeightRequest
    {
        [DataMember]
        public double Weight { get; set; }
    }
}