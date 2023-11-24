using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Education_Service.Controllers
{
    public class AdminCourseController : Controller
    {
        TechedEntities db=new TechedEntities();
      
        // GET: AdminCourse
        public ActionResult Index() //to show all courses
        {
            var obj = db.tblClassCourses.Where(c => c.CourseStatus==true).ToList();
            if (obj!=null) 
            {
                ViewBag.Allcourse = obj;

            }

           

            return View();
        }

               

        public ActionResult AddCourse()
        { 
            return View();
        }
        public ActionResult DeleteCourse() 
        {
            return View();
        }
    }
}