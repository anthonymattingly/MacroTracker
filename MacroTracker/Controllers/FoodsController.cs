﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MacroTracker.Controllers
{
    public class FoodsController : Controller
    {
        // GET: Foods
        public ActionResult Index()
        {
            return View();
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
