using AutoMapper;
using Ecom.Api.Controllers;
using Ecom.Data;
using Ecom.Repository;
using Ecom.Services;
using System.Web.Http;
using System.Web.Mvc;
using Unity;
using Unity.Injection;
using Unity.Lifetime;
using Unity.WebApi;

namespace Ecom.Api
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            container.RegisterType<ApplicationDbContext>(new HierarchicalLifetimeManager());
            container.RegisterType<AccountController>(new InjectionConstructor());

            #region Automapper

            var config = AutomapperConfig.Configure();

            container.RegisterInstance<IMapper>(config.CreateMapper());

            #endregion Automapper

            #region Repositories

            container.RegisterType<ICategoryRepository, CategoryRepository>();
            container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<IOrderRepository, OrderRepository>();
            container.RegisterType<IOrderDetailsRepository, OrderDetailsRepository>();

            #endregion Repositories

            #region Services

            container.RegisterType<ICategoryService, CategoryService>();
            container.RegisterType<IProductService, ProductService>();
            container.RegisterType<IOrderService, OrderService>();

            #endregion Services

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}