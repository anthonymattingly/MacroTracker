using MacroTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace MacroTracker.Controllers
{

    public class FoodController : Controller
    {
        
        private FoodContext db = new FoodContext();

        // GET: Foods
        public ActionResult Index()
        {



            using (var foodContext = new FoodContext())
            {
                var model = new List<Food>();

                model.Add(new Food { FoodId = 1, FoodName = "Peanut Butter", CarbGrams = 4.6, ProteinGrams = 7.1, FatGrams = 30 });
                model.Add(new Food { FoodId = 2, FoodName = "Oatmeal", CarbGrams = 46.2, ProteinGrams = 3, FatGrams = 1.1 });
                model.Add(new Food { FoodId = 3, FoodName = "Peanut Butter", CarbGrams = 13.5, ProteinGrams = 4.1, FatGrams = 14 });
                model.Add(new Food { FoodId = 4, FoodName = "Hamburger", CarbGrams = 53, ProteinGrams = 88.0, FatGrams = 11 });
                return View(model);
            }


        }

        //GET: Foods/Details/5
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
