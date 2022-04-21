using AutoMapper;
using Ecom.Web.Models;
using Ecom.Web.ViewModels;

namespace Ecom.Web
{
    public class AutomapperConfig
    {
        public static MapperConfiguration Configure()
        {
            MapperConfiguration mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Product, ProductViewModel>().AfterMap((src, dest) =>
                {
                    dest.CategoryName = src.Category == null ? "" : src.Category.Name;
                });
                cfg.CreateMap<ProductViewModel, Product>();
                cfg.CreateMap<Category, CategoryViewModel>().ReverseMap();
            });

            return mapperConfiguration;
        }
    }
}