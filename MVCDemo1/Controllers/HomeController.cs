using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About(int id = 1)
        {
            ViewBag.NumberOfTimes = id;

            return View();
        }

        public ActionResult Contact(int id=1)
        {
            ViewBag.Message = "Hello, you typed in the number " + id;

            return View();
        }
    }
}