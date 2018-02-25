using MacroTracker.Models;
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
            using (var foodContext = new FoodContext())
            {
                var foodsEaten = new FoodsConsumed
                {
                    // Convert each Food to a FoodsConsumed
                    FoodsEaten = foodContext.Foods.Select(r => new FoodsConsumed
                    {
                        FoodsConsumedId = r.FoodId,
                        ConsumedFoodName = r.FoodName,
                        ConsumedCarbGrams = r.CarbGrams,
                        ConsumedFatGrams = r.FatGrams,
                        ConsumedProteinGrams = r.ProteinGrams
                    }).ToList()
                };

                //foodsEaten.FoodsEaten = foodsEaten.FoodsEaten.Count();
                return View(foodsEaten);
        };
    }


    [HttpGet]
        public ActionResult Add()
        {
            var foodConsumed = new FoodsConsumed();
            return View("Add", foodConsumed);
        }


        //[HttpPost]
        //public ActionResult Add(FoodsConsumed foodsConsumed)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        using (var foodContext = new FoodContext())
        //        {
        //            foodContext.FoodsConsumedDb.Add(foodsConsumed);
        //            foodContext.SaveChanges();
        //            return RedirectToAction("Index");
        //        }
        //    }
        //    return View(foodsConsumed);
        //}

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