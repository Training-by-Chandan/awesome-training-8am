using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Services;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private StudentService studentService = new StudentService();

        public ActionResult Index()
        {
            var data = GenerateDummyData();
            return View(data);
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

        [Authorize]
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

        private IndexPageViewModel GenerateDummyData()
        {
            var res = new IndexPageViewModel();
            res.Cards = new List<PartialCardViewModel>();
            res.Cards.Add(new PartialCardViewModel() { Body = "This is Arnab", Title = "Arnab Nepal", ImageUrl = "/Theme/admin/dist/img/photo1.png" });
            res.Cards.Add(new PartialCardViewModel() { Body = "This is Jeewsan", Title = "Jeewsan Dhami", ImageUrl = "/Theme/admin/dist/img/photo2.png" });
            res.Cards.Add(new PartialCardViewModel() { Body = "This is Prabi", Title = "Prabi Pradhanange", ImageUrl = "/Theme/admin/dist/img/photo3.jpg" });
            res.Cards.Add(new PartialCardViewModel() { Body = "This is Bishwa", Title = "Bishwa Gautam", ImageUrl = "/Theme/admin/dist/img/photo4.jpg" });
            return res;
        }

        public ActionResult Students()
        {
            var data = studentService.GetAll();
            return View(data);
        }
    }
}