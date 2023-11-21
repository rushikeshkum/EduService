using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Education_Service.Controllers
{
    public class AdminCourseController : Controller
    {
      
        // GET: AdminCourse
        public ActionResult Index() //to show all courses
        {
            return View();
        }
        public ActionResult AddCourse()
        { 
            return View();
        }
        public ActionResult EditCourse()
        {
            return View();

        } public ActionResult DeleteCourse() 
        {
            return View();
        }
    }
}