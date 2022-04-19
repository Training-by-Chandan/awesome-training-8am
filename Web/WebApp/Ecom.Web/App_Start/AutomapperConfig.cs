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
                //use this when the fields are not of same name
                //   cfg.CreateMap<Category, CategoryViewModel>().AfterMap((src, dest) =>{
                //       dest.Active = src.IsActive;
                //});
                //   cfg.CreateMap<CategoryViewModel, Category>().AfterMap((src, dest) => {
                //       dest.IsActive = src.Active;
                //   });

                cfg.CreateMap<Category, CategoryViewModel>().ReverseMap();
            });

            return mapperConfiguration;
        }
    }
}