using Ecom.Data;
using Ecom.Web.Models;
using Ecom.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Repository
{
    public interface ICategoryRepository
    {
        (bool, string) Create(Category model);

        IQueryable<Category> getAll();
    }

    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext db;

        public CategoryRepository(
            ApplicationDbContext db
            )
        {
            this.db = db;
        }

        public IQueryable<Category> getAll()
        {
            return db.Categories;
        }

        public (bool, string) Create(Category model)
        {
            try
            {
                db.Categories.Add(model);
                db.SaveChanges();
                return (true, "Created Successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}