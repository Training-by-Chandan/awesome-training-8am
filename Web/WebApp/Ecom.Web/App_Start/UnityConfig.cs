using AutoMapper;
using Ecom.Data;
using Ecom.Repository;
using Ecom.Services;
using Ecom.Web.Controllers;
using Ecom.Web.ViewModels;
using System.Web.Mvc;
using Unity;
using Unity.Injection;
using Unity.Lifetime;
using Unity.Mvc5;

namespace Ecom.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            container.RegisterType<ApplicationDbContext>(new HierarchicalLifetimeManager());
            container.RegisterType<AccountController>(new InjectionConstructor());
            container.RegisterType<ManageController>(new InjectionConstructor());

            #region Automapper

            var config = AutomapperConfig.Configure();

            container.RegisterInstance<IMapper>(config.CreateMapper());

            #endregion Automapper

            #region Repositories

            container.RegisterType<ICategoryRepository, CategoryRepository>();
            container.RegisterType<IProductRepository, ProductRepository>();

            #endregion Repositories

            #region Services

            container.RegisterType<ICategoryService, CategoryService>();
            container.RegisterType<IProductService, ProductService>();

            #endregion Services

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}