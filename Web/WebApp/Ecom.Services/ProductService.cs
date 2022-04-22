using AutoMapper;
using Ecom.Repository;
using Ecom.Web.Models;
using Ecom.Web.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Ecom.Services
{
    public interface IProductService
    {
        (bool, string) Create(ProductViewModel model);

        List<ProductViewModel> GetAll();
    }

    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;
        private readonly IMapper mapper;

        public ProductService(
            IProductRepository productRepository,
            IMapper mapper
            )
        {
            this.productRepository = productRepository;
            this.mapper = mapper;
        }

        public List<ProductViewModel> GetAll()
        {
            try
            {
                var data = productRepository.GetAll().ToList();
                return mapper.Map<List<Product>, List<ProductViewModel>>(data);
            }
            catch (System.Exception ex)
            {
                return new List<ProductViewModel>();
            }
        }

        public (bool, string) Create(ProductViewModel model)
        {
            try
            {
                var product = mapper.Map<ProductViewModel, Product>(model);
                return productRepository.Create(product);
            }
            catch (System.Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}