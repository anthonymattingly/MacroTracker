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
        
        private FoodContext db = new FoodContext();

        [HttpGet]
        public ActionResult Index()
        {
            return View(db.FoodExamples.ToList());
        }

        [HttpGet]
        public ActionResult Details(int? id)
        {
            //ToDo--Make sure duplicate item not selected
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }


            return View(db.FoodExamples.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            var food = new Food();
            return View("Create", food);
        }

        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        [HttpPost]
       [ValidateAntiForgeryToken]
        public ActionResult CreateFood([Bind(Include = "FoodName, FatGrams, CarbGrams, ProteinGrams")]Food food)
        {
            using (var foodContext = new FoodContext()) { 
            try
            {
                if (ModelState.IsValid)
                {
                        db.FoodExamples.Add(food);
                        db.SaveChanges();
                        return RedirectToAction("Index");
                        //foodContext.FoodExamples.Add(food);
                        //foodContext.SaveChanges();
                        //return RedirectToAction("Index");
                    }
                }
            catch (DataException /* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(food);
        }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View();
        }

        
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
        public ActionResult DeleteEntry(int id, FormCollection collection)
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
