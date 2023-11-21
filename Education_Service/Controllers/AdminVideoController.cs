using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Education_Service.Controllers
{
    public class AdminVideoController : Controller
    {
        // Show all Video using this Action
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddVideo()
        {
            return View();
        }
    }
}