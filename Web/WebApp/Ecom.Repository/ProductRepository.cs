using Ecom.Data;

namespace Ecom.Repository
{
    public interface IProductRepository
    {
    }

    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext db;

        public ProductRepository(
            ApplicationDbContext db
            )
        {
            this.db = db;
        }
    }
}