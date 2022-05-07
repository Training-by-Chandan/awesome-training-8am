using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ecom.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Web.Tests
{
    [TestClass()]
    public class MathOpsTests
    {
        [TestMethod()]
        public void AddTest()
        {
            MathOps ops = new MathOps();
            int a = 2;
            int b = 2;
            var res = ops.Add(a, b);
            var expected = 4;
            Assert.AreEqual(expected, res);
        }

        [TestMethod()]
        public void AddTestV2()
        {
            MathOps ops = new MathOps();
            int a = 2;
            int b = 0;
            var res = ops.Add(a, b);
            var expected = 2;
            Assert.AreEqual(expected, res);
        }

        [TestMethod()]
        public void AddTestV3()
        {
            MathOps ops = new MathOps();
            int a = -2;
            int b = 1;
            var res = ops.Add(a, b);
            var expected = -1;
            Assert.AreEqual(expected, res);
        }

        [TestMethod()]
        public void AddTestV4()
        {
            MathOps ops = new MathOps();
            int a = 0;
            int b = 1;
            Assert.ThrowsException<NotSupportedException>(() =>
            {
                ops.Add(a, b);
            });
        }
    }
}