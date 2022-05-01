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
using Microsoft.AspNet.Identity;

namespace Ecom.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService productService;
        private readonly IMapper mapper;
        private readonly IOrderService orderService;

        public HomeController(
            IProductService productService,
            IMapper mapper,
            IOrderService orderService
            )
        {
            this.productService = productService;
            this.mapper = mapper;
            this.orderService = orderService;
        }

        public ActionResult Index()
        {
            var data = productService.GetAll();
            return View(data);
        }

        public void SendEmail()
        {
            Thread.Sleep(120000);
        }

        [HttpGet]
        [Route("about-us")]
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
        public ActionResult AddToCart(Guid ProductId, int Quantity = 1)
        {
            var cart = Session["Cart"] as SessionViewModel;
            if (cart == null) cart = new SessionViewModel();
            var existingProduct = cart.Products.FirstOrDefault(p => p.ProductId == ProductId);
            if (existingProduct == null)
            {
                var product = productService.GetById(ProductId);
                var sessionProduct = mapper.Map<ProductViewModel, ProductSessionViewModel>(product);
                sessionProduct.Quantity = Quantity;
                cart.Products.Add(sessionProduct);
            }
            else
            {
                existingProduct.Quantity += Quantity;
            }

            Session["Cart"] = cart;
            return Redirect(Request.UrlReferrer.AbsoluteUri);
            // return RedirectToAction("index");
        }

        public ActionResult Checkout()
        {
            return View();
        }

        [Authorize]
        [HttpGet]
        public ActionResult ConfirmCheckout()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult ConfirmCheckout(string Address)
        {
            var cart = Session["Cart"] as SessionViewModel;
            var res = orderService.AddOrder(cart, Address, User.Identity.GetUserId());
            if (res.Item1)
            {
                Session["Cart"] = null;
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
    }
}