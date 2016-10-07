using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ExerService
{
    [DataContract]
    public class ErrorListResponse
    {   
        public ErrorListResponse()
        {
            this.errorList = new List<string>();
        }                
        public List<string> errorList { get; set; }
    }
}