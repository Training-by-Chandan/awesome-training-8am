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
        public ActionResult Create(ProductViewModel model, HttpPostedFileBase productImage)
        {
            ViewBag.Categories = categoryService.GetCategoriesListItems();

            if (!ModelState.IsValid) return View(model);
            //save the file and map its path
            if (productImage.ContentLength > 0)
            {
                //save the file
                var fileName = productImage.FileName;
                var extension = System.IO.Path.GetExtension(fileName);
                var newFile = Guid.NewGuid().ToString() + extension;
                var fullPath = "/Uploads/Product/" + newFile;
                //path mapping to db
                model.FilePath = fullPath;
                var mappedFile = Server.MapPath(fullPath);
                productImage.SaveAs(mappedFile);
            }

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

        [HttpGet]
        public ActionResult Edit(Guid id)
        {
            var product = productService.GetById(id);
            ViewBag.Categories = categoryService.GetCategoriesListItems();
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(ProductViewModel model, HttpPostedFileBase productImage)
        {
            ViewBag.Categories = categoryService.GetCategoriesListItems();

            if (!ModelState.IsValid) return View(model);
            //save the file and map its path
            if (productImage != null && productImage.ContentLength > 0)
            {
                //save the file
                var fileName = productImage.FileName;
                var extension = System.IO.Path.GetExtension(fileName);
                var newFile = Guid.NewGuid().ToString() + extension;
                var fullPath = "/Uploads/Product/" + newFile;
                //path mapping to db
                var mappedFile = Server.MapPath(fullPath);
                productImage.SaveAs(mappedFile);
                //delete existing pictur
                if (model.FilePath!=null)
                {

                System.IO.File.Delete(Server.MapPath(model.FilePath));
                }
                model.FilePath = fullPath;
            }

            var res = productService.Edit(model);
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