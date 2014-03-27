using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Prototype application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Kobi Eliasi.";

            return View();
        }
    }
}