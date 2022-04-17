using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Services;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    [Authorize(Roles = "Admin")]
    public class StudentController : Controller
    {
        private readonly IStudentService studentService;

        public StudentController()
        {
            studentService = new StudentService();
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult Index()
        {
            var data = studentService.GetAll();
            return View(data);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StudentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var res = studentService.Create(model);
            if (res)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data = studentService.GetById(id);
            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(StudentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var result = studentService.Edit(model);
            if (result)
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