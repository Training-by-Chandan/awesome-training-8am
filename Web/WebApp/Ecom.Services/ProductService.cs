using Ecom.Repository;

namespace Ecom.Services
{
    public interface IProductService
    {
    }

    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(
            IProductRepository productRepository
            )
        {
            this.productRepository = productRepository;
        }
    }
}