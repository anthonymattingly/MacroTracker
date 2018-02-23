using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


//Entries Controller will Calculate and Display total Macros for the day


namespace MacroTracker.Controllers
{
    public class FoodsConsumedController : Controller
    {
        // GET: Entries
        [HttpGet]
        public ActionResult Index()
        {
            
                return View();
            
        }

        public ActionResult Add()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Add(DateTime? date, int? activityId, double? duration,
        //   Entry.IntensityLevel? intensity, bool? exclude, string notes)
        //{
        //    ViewBag.Date = ModelState["Date"].Value.AttemptedValue;
        //    ViewBag.ActivityId = ModelState["ActivityId"].Value.AttemptedValue;
        //    ViewBag.Duration = ModelState["Duration"].Value.AttemptedValue;
        //    ViewBag.Intensity = ModelState["Intensity"].Value.AttemptedValue;
        //    ViewBag.Exclude = ModelState["Exclude"].Value.AttemptedValue;
        //    ViewBag.Notes = ModelState["Notes"].Value.AttemptedValue;
        //    return View();
        //}


    }
}