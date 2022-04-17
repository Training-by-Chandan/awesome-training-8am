using Ecom.Repository;
using Ecom.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Services
{
    public interface ICategoryService
    {
        IQueryable<CategoryViewModel> GetAll();
    }

    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryService(
            ICategoryRepository categoryRepository
            )
        {
            this.categoryRepository = categoryRepository;
        }

        public IQueryable<CategoryViewModel> GetAll()
        {
            try
            {
                var data = categoryRepository.getAll().Select(p => new CategoryViewModel()
                {
                    Id = p.Id,
                    Description = p.Description,
                    Name = p.Name
                });
                return data;
            }
            catch (Exception ex)
            {
                return (new List<CategoryViewModel>()).AsQueryable();
            }
        }
    }
}