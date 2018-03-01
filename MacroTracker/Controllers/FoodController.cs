using MacroTracker.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;



namespace MacroTracker.Controllers
{

    public class FoodController : Controller
    {

        [HttpGet]
        public ActionResult Index()
        {
            using (var foodContext = new FoodContext())
            {
                var foodListViewModel = new FoodListViewModel();
                foodListViewModel.Foods = foodContext.Foods.Select(f => new FoodViewModel
                {
                    FoodId = f.FoodId,
                    FoodName = f.FoodName,
                    CarbGrams = f.CarbGrams,
                    ProteinGrams = f.ProteinGrams,
                    FatGrams = f.FatGrams
                }).ToList();
                return View(foodListViewModel);
            }
        }

        //Method adds to list of foods the user has consumed for the day rather than list of foods to choose from
        //The button to add list of foods the user has consumed appears in Index view
        //[HttpPost]
        //public ActionResult Index(FoodsConsumed foodsConsumed)
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



        [HttpGet]
        public ActionResult Details(int? id)
        {
            
            using (var foodContext = new FoodContext())
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }

                var foodViewModel = foodContext.Foods.SingleOrDefault(f => f.FoodId == id);

                if (foodViewModel == null)
                {
                    return HttpNotFound();
                }


                return View(foodViewModel);
            }
        }

        [HttpGet]
        public ActionResult Create()
        {
            var foodViewModel = new FoodViewModel();
            return View("Create", foodViewModel);
        }


        [HttpPost]
        public ActionResult Create(Food food)
        {
            if (ModelState.IsValid)
            {
                using (var foodContext = new FoodContext())
                {
                    foodContext.Foods.Add(food);
                    foodContext.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View(food);
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

                var foodViewModel = foodContext.Foods.SingleOrDefault(f => f.FoodId == id);

                if (foodViewModel == null)
                {
                    return HttpNotFound();
                }
                return View(foodViewModel);
            }
        }

        [HttpPost]
        public ActionResult Edit(FoodViewModel foodViewModel)
        {
            if (ModelState.IsValid)
            {
                using (var foodContext = new FoodContext())

                {
                    var foodToUpdate = foodContext.Foods.SingleOrDefault(f => f.FoodId == foodViewModel.FoodId);

                    if (foodToUpdate != null)
                    {
                        foodToUpdate.FoodName = foodViewModel.FoodName;
                        foodToUpdate.ProteinGrams = foodViewModel.ProteinGrams;
                        foodToUpdate.CarbGrams = foodViewModel.CarbGrams;
                        foodToUpdate.FatGrams = foodViewModel.FatGrams;
                        foodContext.SaveChanges();
                        return RedirectToAction("Index");
                    }
                    
                }     
            }
            return new HttpNotFoundResult();
        }


        // GET: Food/Delete/5
        public ActionResult Delete(int? id)
        {
            using (var foodContext = new FoodContext())
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }

                Food food = foodContext.Foods.Find(id);

                if (food == null)
                {
                    return HttpNotFound();
                }

                return View(food);
            }
        }

        // POST: Foods/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            using (var foodContext = new FoodContext())
            {
                Food food = foodContext.Foods.Find(id);
                foodContext.Foods.Remove(food);
                foodContext.SaveChanges();

                return RedirectToAction("Index");
            }
        }
    }
}
