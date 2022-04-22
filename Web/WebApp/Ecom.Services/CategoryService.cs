using AutoMapper;
using Ecom.Repository;
using Ecom.Web.Models;
using Ecom.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Ecom.Services
{
    public interface ICategoryService
    {
        (bool, string) Create(CategoryViewModel model);

        List<CategoryViewModel> GetAll();

        List<SelectListItem> GetCategoriesListItems();
    }

    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;

        private readonly IMapper mapper;

        public CategoryService(
            ICategoryRepository categoryRepository,
            IMapper mapper
            )
        {
            this.categoryRepository = categoryRepository;
            this.mapper = mapper;
        }

        public List<CategoryViewModel> GetAll()
        {
            try
            {
                var cats = categoryRepository.GetAll().ToList();
                var data = mapper.Map<List<Category>, List<CategoryViewModel>>(cats);
                return data.ToList();
            }
            catch (Exception ex)
            {
                Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
                return new List<CategoryViewModel>();
            }
        }

        public (bool, string) Create(CategoryViewModel model)
        {
            try
            {
                var category = mapper.Map<CategoryViewModel, Category>(model);
                category.Id = Guid.NewGuid();
                return categoryRepository.Create(category);
            }
            catch (Exception ex)
            {
                //todo log the exceptions somewhere
                Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
                return (false, ex.Message);
            }
        }

        public List<SelectListItem> GetCategoriesListItems()
        {
            return categoryRepository.GetAll().Select(p => new SelectListItem()
            {
                Text = p.Name,
                Value = p.Id.ToString()
            }).ToList();
        }
    }
}