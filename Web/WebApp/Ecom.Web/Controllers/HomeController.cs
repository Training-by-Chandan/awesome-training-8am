using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ecom.Services;
using Ecom.Web.ViewModels;

namespace Ecom.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService categoryService;

        public HomeController(
            ICategoryService categoryService
            )
        {
            this.categoryService = categoryService;
        }

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

        public ActionResult Categories()
        {
            var data = categoryService.GetAll();
            return View(data.ToList());
        }

        [HttpGet]
        public ActionResult CreateCategories()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCategories(CategoryViewModel model)
        {
            //check the validation of model
            if (!ModelState.IsValid) return View(model);

            //send the request to the service
            var res = categoryService.Create(model);
            //manage the return as per the status
            if (res.Item1)
            {
                return RedirectToAction("Categories");
            }
            else
            {
                return View(model);
            }
        }
    }
}