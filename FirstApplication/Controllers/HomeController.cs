using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "We will describe about us later.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "You can contact me on 8755509806.";

            return View();
        }
    }
}