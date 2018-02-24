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
                return View(foodContext.Foods.ToList());
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

                Food food = foodContext.Foods.Find(id);

                if (food == null)
                {
                    return HttpNotFound();
                }
                return View(food);
            }
        }

        [HttpGet]
        public ActionResult Create()
        {
            var food = new Food();
            return View("Create", food);
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

                Food food = foodContext.Foods.Find(id);

                if (food == null)
                {
                    return HttpNotFound();
                }
                return View(food);
            }
        }

        [HttpPost]
        public ActionResult Edit(Food food)
        {
            if (ModelState.IsValid)
            {
                using (var foodContext = new FoodContext())

                {
                    var foodToUpdate = foodContext.Foods.Find(food.FoodId);
                    foodToUpdate.FoodName = food.FoodName;
                    foodToUpdate.ProteinGrams = food.ProteinGrams;
                    foodToUpdate.CarbGrams = food.CarbGrams;
                    foodToUpdate.FatGrams = food.FatGrams;
                    foodContext.SaveChanges();
                    return RedirectToAction("Index");
                }     
            }
            return View(food);
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
