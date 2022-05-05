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

        (bool, string) Delete(Guid Id);

        (bool, string) Edit(CategoryViewModel model);

        List<CategoryViewModel> GetAll();

        CategoryViewModel GetbyId(Guid Id);

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

        public CategoryViewModel GetbyId(Guid Id)
        {
            var data = categoryRepository.FindById(Id);
            var res = mapper.Map<Category, CategoryViewModel>(data);
            return res;
        }

        public (bool, string) Edit(CategoryViewModel model)
        {
            try
            {
                var existing = categoryRepository.FindById(model.Id);
                if (existing == null) return (false, "Category not found");

                var category = mapper.Map<CategoryViewModel, Category>(model, existing);

                return categoryRepository.Edit(category);
            }
            catch (Exception ex)
            {
                //todo log the exceptions somewhere
                Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
                return (false, ex.Message);
            }
        }

        public (bool, string) Delete(Guid Id)
        {
            try
            {
                var existing = categoryRepository.FindById(Id);
                if (existing == null) return (false, "Category not found");
                return categoryRepository.Delete(Id);
            }
            catch (Exception ex)
            {
                //todo log the exceptions somewhere
                Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
                return (false, ex.Message);
            }
        }
    }
}