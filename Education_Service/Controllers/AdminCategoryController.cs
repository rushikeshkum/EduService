﻿using Education_Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Education_Service.Controllers
{
    public class AdminCategoryController : Controller
    {
        TechedEntities db = new TechedEntities();

        public ActionResult AddCourseCategory(int id = 0)
        {
            ViewBag.category = db.tblClassCategories.ToList();

            if (id > 0)
            {
                tblClassCategory obj = db.tblClassCategories.Find(id);
                if (obj != null)
                {
                    return View(obj);

                }

            }
            return View();
        }

        [HttpPost]
        public ActionResult AddCourseCategory(tblClassCategory C)
        {
            try
            {


                db.tblClassCategories.Attach(C);
                db.Entry(C).State = C.id > 0 ? System.Data.Entity.EntityState.Modified : System.Data.Entity.EntityState.Added;
                db.SaveChanges();

                ViewBag.category = db.tblClassCategories.ToList();

            }
            catch (Exception)
            {


            }

            return View();
        }

        public ActionResult Delete(int id)
        {
            tblClassCategory obj = db.tblClassCategories.Find(id);
            if (obj != null)
            {
                db.tblClassCategories.Remove(obj);
                db.SaveChanges();
              


            }

            return RedirectToAction("AddCourseCategory");
        }

       
    }
}