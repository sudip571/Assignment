using PreAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PreAssignment.Controllers
{
    public class DynamicFormGeneratorController : Controller
    {
        // GET: DynamicFormGenerator
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetDynamicForm()
        {
            var models = new List<DynamicFormModel>();
            models.Add(new DynamicFormModel
            {
                Field = "Id",
                Type = "Number",
                Min_Value = 1
            });
            models.Add(new DynamicFormModel
            {
                Field = "Name",
                Type = "text",
                Max_Length = 100
            });
            models.Add(new DynamicFormModel
            {
                Field = "Description",
                Type = "LongText",
                Max_Length = 1000
            });
            models.Add(new DynamicFormModel
            {
                Field = "Score",
                Type = "DropDownList",
                Allowed_Values = new List<string>() { "0-3", "4-7", "8+" }
            });
            models.Add(new DynamicFormModel
            {
                Field = "Gender",
                Type = "RadioButton",
                Allowed_Values = new List<string>() { "Male", "Female" }
            });
            models.Add(new DynamicFormModel
            {
                Field = "Interests",
                Type = "CheckBox",
                Allowed_Values = new List<string>() { "C#", "SQL", "Python" }
            });


            return Json(models, JsonRequestBehavior.AllowGet);
        }
    }
}