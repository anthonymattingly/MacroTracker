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
            return View(db.Foods.ToList());
        }

        [HttpGet]
        public ActionResult Details(int? id)
        {
            //ToDo--Make sure duplicate item not selected
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }


            return View(db.Foods.ToList());
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
        public ActionResult Create([Bind(Include = "FoodName, FatGrams, CarbGrams, ProteinGrams")]Food food)
        {
            using (var foodContext = new FoodContext()) { 
            try
            {
                if (ModelState.IsValid)
                {
                        db.Foods.Add(food);
                        db.SaveChanges();
                        return RedirectToAction("Index");
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

        // GET: Food/Delete/5
        public ActionResult Delete(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Delete failed. Try again, and if the problem persists see your system administrator.";
            }
            Food food = db.Foods.Find(id);
            if (food == null)
            {
                return HttpNotFound();
            }
            return View(food);
        }

        // POST: Foods/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                Food food = db.Foods.Find(id);
                db.Foods.Remove(food);
                db.SaveChanges();
            }
            catch (DataException/* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                return RedirectToAction("Delete", new { id = id, saveChangesError = true });
            }
            return RedirectToAction("Index");
        }
    }
}
