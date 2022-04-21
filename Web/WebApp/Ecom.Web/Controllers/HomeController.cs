using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using Ecom.Services;
using Ecom.Web.ViewModels;
using Hangfire;

namespace Ecom.Web.Controllers
{
    public class HomeController : Controller
    {
       
     

        public ActionResult Index()
        {
            //var jobId = BackgroundJob.Enqueue(
            //() => SendEmail());
            return View();
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

      
    }
}