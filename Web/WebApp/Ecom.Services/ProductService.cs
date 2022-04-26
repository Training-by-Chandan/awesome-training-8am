using AutoMapper;
using Ecom.Repository;
using Ecom.Web.Models;
using Ecom.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ecom.Services
{
    public interface IProductService
    {
        (bool, string) Create(ProductViewModel model);

        (bool, string) Edit(ProductViewModel model);

        List<ProductViewModel> GetAll();

        ProductViewModel GetById(Guid id);
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

        public ProductViewModel GetById(Guid id)
        {
            try
            {
                var data = productRepository.FindById(id);
                var product = mapper.Map<Product, ProductViewModel>(data);
                return product;
            }
            catch (Exception ex)
            {
                Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
                return new ProductViewModel();
            }
        }

        public (bool, string) Edit(ProductViewModel model)
        {
            try
            {
                var existing = productRepository.FindById(model.Id);
                if (existing == null) return (false, "Product not found");

                var product = mapper.Map<ProductViewModel, Product>(model, existing);
                return productRepository.Edit(existing);
            }
            catch (System.Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}