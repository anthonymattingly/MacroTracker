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

                var foodViewModel = foodContext.Foods.SingleOrDefault(f => f.FoodId == id);

                if (foodViewModel == null)
                {
                    return HttpNotFound();
                }
                return View(foodViewModel);
            }
        }

        // POST: Foods/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            using (var foodContext = new FoodContext())
            {

                var foodToDelete = foodContext.Foods.SingleOrDefault(f => f.FoodId == id);

                if(foodToDelete != null)
                {
                    foodContext.Foods.Remove(foodToDelete);
                    foodContext.SaveChanges();
                }

                return RedirectToAction("Index");
            }
        }
    }
}
