using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcWCFExer
{ 
    public class BMIModel
    {
        [Display(Name = "Feet: ")]
        public double FtValue { get; set; }

        [Display(Name = "Centimeters: ")]
        public double cmValue { get; set; }

        [Display(Name = "Kilogram: ")]
        public double kgValue { get; set; }

        [Display(Name = "Lbs: ")]
        public double lbValue { get; set; }

        [Display(Name = "Height(cm): ")]
        public double bmiHeight { get; set; }

        [Display(Name = "Weight(kg): ")]
        public double bmiWeight { get; set; }

        [Display(Name = "Status: ")]
        public string bmiStatus { get; set; }
    }
}