using Ecom.Services;
using Ecom.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecom.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = StrConst.Roles.Admin)]
    public class DashboardController : Controller
    {
        private readonly ICategoryService categoryService;

        public DashboardController(
            ICategoryService categoryService
            )
        {
            this.categoryService = categoryService;
        }

        // GET: Admin/Dashboard
        public ActionResult Index()
        {
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