using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ecom.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Ecom.Services;
using Ecom.Web.ViewModels;
using AutoMapper;
using System.Web.Mvc;

namespace Ecom.Web.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        private HomeController home;

        //[TestInitialize()]
        //public void Setup()
        //{
        //}

        [TestMethod()]
        public void IndexTest()
        {
            var data = new List<ProductViewModel>();
            data.Add(new ProductViewModel());
            data.Add(new ProductViewModel());

            var mockProduct = new Mock<IProductService>();
            mockProduct.Setup(x => x.GetAll()).Returns(data);
            home = new HomeController(mockProduct.Object, null, null);
            var res = home.Index();
            Assert.IsNotNull(res);
            Assert.IsInstanceOfType(res, typeof(ActionResult));
        }
    }
}