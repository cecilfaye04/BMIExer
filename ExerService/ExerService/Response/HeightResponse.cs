using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ExerService
{
    [DataContract]
    public class HeightResponse : ErrorListResponse
    {        
        [DataMember]
        public double Height { get; set; }
    }
}