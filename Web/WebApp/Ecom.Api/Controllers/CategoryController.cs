using Ecom.Services;
using Ecom.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ecom.Api.Controllers
{
    public class CategoryController : ApiController
    {
        private readonly ICategoryService categoryService;

        public CategoryController(
            ICategoryService categoryService
            )
        {
            this.categoryService = categoryService;
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var data = categoryService.GetAll();
            if (data == null || data.Count == 0)
            {
                return NotFound();
            }
            return Json(data);
        }

        [HttpPost]
        public IHttpActionResult Create(CategoryViewModel model)
        {
            var data = categoryService.Create(model);
            if (data.Item1)
            {
                return Ok();
            }
            else
            {
                return BadRequest(data.Item2);
            }
        }

        [HttpPost]
        public IHttpActionResult Edit(CategoryViewModel model)
        {
            var data = categoryService.Edit(model);
            if (data.Item1)
            {
                return Ok();
            }
            else
            {
                return BadRequest(data.Item2);
            }
        }

        [HttpGet]
        public IHttpActionResult Delete(Guid id)
        {
            var data = categoryService.Delete(id);
            if (data.Item1)
            {
                return Ok();
            }
            else
            {
                return BadRequest(data.Item2);
            }
        }

        [HttpGet]
        public IHttpActionResult GetById(Guid Id)
        {
            var data = categoryService.GetbyId(Id);
            if (data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }
    }
}