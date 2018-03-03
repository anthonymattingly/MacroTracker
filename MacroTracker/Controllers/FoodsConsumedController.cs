using MacroTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;


//Entries Controller will Calculate and Display total Macros for the day


namespace MacroTracker.Controllers
{
    public class FoodsConsumedController : Controller
    {
        //GET: Entries
        [HttpGet]
        public ActionResult Index()
        {
            using (var foodContext = new FoodContext())
            {
                var foodsEaten = new FoodsConsumedListViewModel
                {
                    // Convert each Food to a FoodsConsumed
                    FoodsEaten = foodContext.FoodsConsumedDb.Select(r => new FoodsConsumedViewModel
                    {
                        FoodsConsumedId = r.FoodsConsumedId,
                        ConsumedFoodName = r.ConsumedFoodName,
                        ConsumedCarbGrams = r.ConsumedCarbGrams,
                        ConsumedFatGrams = r.ConsumedFatGrams,
                        ConsumedProteinGrams = r.ConsumedProteinGrams
                    }).ToList()
                };

                //foodsEaten.FoodsEaten = foodsEaten.FoodsEaten.Count();
                return View(foodsEaten);
            };
        }


        [HttpGet]
        public ActionResult Details(int? id)
        {

            using (var foodContext = new FoodContext())
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }

                var foodConsumedDetail = foodContext.FoodsConsumedDb.SingleOrDefault(f => f.FoodsConsumedId == id);

                    var foodsConsumedViewModel = new FoodsConsumedViewModel
                    {
                        FoodsConsumedId = foodConsumedDetail.FoodsConsumedId,
                        ConsumedFoodName = foodConsumedDetail.ConsumedFoodName,
                        ConsumedCarbGrams = foodConsumedDetail.ConsumedCarbGrams,
                        ConsumedFatGrams = foodConsumedDetail.ConsumedFatGrams,
                        ConsumedProteinGrams = foodConsumedDetail.ConsumedProteinGrams
                    };
                    return View(foodsConsumedViewModel);
            }
        }


        [HttpGet]
        public ActionResult Edit(int? id)
        {
            using (var foodContext = new FoodContext())
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }

                var foodsConsumedViewModel = foodContext.FoodsConsumedDb.SingleOrDefault(f => f.FoodsConsumedId == id);

                if (foodsConsumedViewModel == null)
                {
                    return HttpNotFound();
                }
                return View(foodsConsumedViewModel);
            }
        }

        [HttpPost]
        public ActionResult Edit(FoodsConsumedViewModel foodsConsumedViewModel)
        {
            if (ModelState.IsValid)
            {
                using (var foodContext = new FoodContext())

                {
                    var foodToUpdate = foodContext.FoodsConsumedDb.SingleOrDefault(f => f.FoodsConsumedId == foodsConsumedViewModel.FoodsConsumedId);

                    if (foodToUpdate != null)
                    {
                        foodToUpdate.ConsumedFoodName = foodsConsumedViewModel.ConsumedFoodName;
                        foodToUpdate.ConsumedProteinGrams = foodsConsumedViewModel.ConsumedProteinGrams;
                        foodToUpdate.ConsumedCarbGrams = foodsConsumedViewModel.ConsumedCarbGrams;
                        foodToUpdate.ConsumedFatGrams = foodsConsumedViewModel.ConsumedFatGrams;
                        foodContext.SaveChanges();
                        return RedirectToAction("Index");
                    }

                }
            }
            return new HttpNotFoundResult();
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            using (var foodContext = new FoodContext())
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }

                var foodConsumedViewModel = foodContext.FoodsConsumedDb.SingleOrDefault(f => f.FoodsConsumedId == id);

                if (foodConsumedViewModel == null)
                {
                    return HttpNotFound();
                }
                return View(foodConsumedViewModel);
            }
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            using (var foodContext = new FoodContext())
            {

                var foodConsumedToDelete = foodContext.FoodsConsumedDb.SingleOrDefault(f => f.FoodsConsumedId == id);

                if (foodConsumedToDelete != null)
                {
                    foodContext.FoodsConsumedDb.Remove(foodConsumedToDelete);
                    foodContext.SaveChanges();
                }

                return RedirectToAction("Index");
            }
        }



    }
}

