using Ecom.Services;
using Ecom.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecom.Web.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;

        public ProductController(
            IProductService productService,
             ICategoryService categoryService
            )
        {
            this.productService = productService;
            this.categoryService = categoryService;
        }

        // GET: Admin/Product
        public ActionResult Index()
        {
            var data = productService.GetAll();
            return View(data);
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Categories = categoryService.GetCategoriesListItems();
            return View();
        }

        [HttpPost]
        public ActionResult Create(ProductViewModel model)
        {
            ViewBag.Categories = categoryService.GetCategoriesListItems();

            if (!ModelState.IsValid) return View(model);

            var res = productService.Create(model);
            if (res.Item1)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
    }
}