using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecom.Web.Controllers
{
    public class ReportController : Controller
    {
        // GET: Report
        public ActionResult Index(string reportName)
        {
            ViewBag.report = reportName;
            return View();
        }
    }
}