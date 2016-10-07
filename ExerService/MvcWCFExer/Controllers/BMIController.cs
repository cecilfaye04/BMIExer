using MvcWCFExer.BMIService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWCFExer.Controllers
{
    public class BMIController : Controller
    {
        // GET: BMI
        Manager bmiManager = new Manager();
        HeightRequest height;
        WeightRequest weight;
        CalculateBMIRequest bmi;

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BMIMainPage()
        {
            return View();
        }

        public JsonResult GetFtToCm(double ft)
        {
            height = new HeightRequest() { Height = ft };
            var result = bmiManager.ConvertFtToCm(height);
            return Json(new { Result = result.Height }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetCmToFt(double cm)
        {
            height = new HeightRequest() { Height = cm };
            var result = bmiManager.ConvertCmToFt(height);
            return Json(new { Result = result.Height }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetKgToLb(double kg)
        {
            weight = new WeightRequest() { Weight = kg };
            var result = bmiManager.ConvertKgToLb(weight);
            return Json(new { Result = result.Weight }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetLbToKg(double lb)
        {
            weight = new WeightRequest() { Weight = lb };
            var result = bmiManager.ConvertLbToKg(weight);
            return Json(new { Result = result.Weight }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetBMI(double height, double weight)
        {
            bmi = new CalculateBMIRequest() { Height = height, Weight = weight };
            var result = bmiManager.CalculateBMI(bmi);
            return Json(new { Result = result.BMI , Status = result.Status }, JsonRequestBehavior.AllowGet);
        }
    }
}