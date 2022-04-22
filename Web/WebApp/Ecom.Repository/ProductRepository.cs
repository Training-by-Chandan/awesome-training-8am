using Ecom.Data;
using Ecom.Web.Models;
using System.Linq;

namespace Ecom.Repository
{
    public interface IProductRepository : IBaseRepository<Product>
    {
    }

    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}