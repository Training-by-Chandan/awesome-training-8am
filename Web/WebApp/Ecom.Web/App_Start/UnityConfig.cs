using Ecom.Repository;
using Ecom.Services;
using Ecom.Web.Models;
using System.Web.Mvc;
using Unity;
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
            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<ICategoryRepository, CategoryRepository>();

            container.RegisterType<ICategoryService, CategoryService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}