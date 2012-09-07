using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        //public string Index()
        {
            //ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
            //return "This is my <b>default</b> action...";  

        }

        public ActionResult LogOn()
        {
            //ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
            //return "This is my <b>Welcome</b> action...";

        }


        public ActionResult About()
        {
            return View();
        }
    }
}
