using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Jeewsan()
        {
            return View();
        }

        public ActionResult Prabi(int page = 0)
        {
            if (page == 0)
            {
                return View("Jeewsan");
            }
            else
            {
                return View("Contact");
            }
        }

        public ActionResult Display(string name)
        {
            ViewBag.Name = name;
            return View();
        }
    }
}