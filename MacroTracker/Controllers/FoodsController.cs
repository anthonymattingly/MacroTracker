using MacroTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static MacroTracker.Models.Food;

namespace MacroTracker.Controllers
{

    public class FoodsController : Controller
    {

       

       public List<Food> foodExamples = new List<Food>
       {
           new Food{ FoodId = 1, FoodName = "Avocado", FatGrams = 30.1, ProteinGrams = 3.3, CarbGrams = 4 },
           new Food{ FoodId = 2, FoodName = "Greek Yogurt", FatGrams = 0, ProteinGrams = 25, CarbGrams = 5 },
           new Food{ FoodId = 3, FoodName = "Small Chicken Breast", FatGrams = 0.8, ProteinGrams = 22.5, CarbGrams = 4.1 },
           new Food{ FoodId = 4, FoodName = "Banana", FatGrams = 2, ProteinGrams = 1.2, CarbGrams = 35.2 }
       };
        
        // GET: Foods
        public ActionResult Index()
        {
           
            return View(foodExamples);
        }

        // GET: Foods/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Foods/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Foods/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Foods/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Foods/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Foods/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Foods/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
