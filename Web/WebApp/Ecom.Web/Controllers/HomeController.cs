using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Ecom.Services;
using Ecom.Web.ViewModels;
using Hangfire;

namespace Ecom.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService productService;
        private readonly IMapper mapper;
        public HomeController(
            IProductService productService, 
            IMapper mapper
            )
        {
            this.productService = productService;
            this.mapper = mapper;
        }
        

        public ActionResult Index()
        {
            var data=productService.GetAll();
            return View(data);
        }

        public void SendEmail()
        {
            Thread.Sleep(120000);
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

        [HttpGet]
        public ActionResult AddToCart(Guid ProductId, int Quantity=1)
        {
            var cart = Session["Cart"] as SessionViewModel;
            if (cart == null) cart = new SessionViewModel();
            var existingProduct = cart.Products.FirstOrDefault(p => p.ProductId == ProductId);
            if (existingProduct==null)
            {
                var product = productService.GetById(ProductId);
                var sessionProduct=mapper.Map<ProductViewModel, ProductSessionViewModel>(product);
                sessionProduct.Quantity = Quantity;
                cart.Products.Add(sessionProduct);
            }
            else
            {
                existingProduct.Quantity += Quantity;
            }

            Session["Cart"] = cart;
            return RedirectToAction("index");
        }
      
    }
}