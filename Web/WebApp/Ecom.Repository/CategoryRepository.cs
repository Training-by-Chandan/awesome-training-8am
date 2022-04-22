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
    public interface ICategoryRepository : IBaseRepository<Category>
    {
    }

    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}