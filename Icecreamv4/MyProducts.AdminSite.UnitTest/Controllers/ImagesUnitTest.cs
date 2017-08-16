using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using MyProducts.AdminSite;
using MyProducts.AdminSite.Controllers;
using MyProducts.AdminSite.Models;
using System.Web.Mvc;

namespace MyProducts.AdminSite.UnitTest.Controllers
{
    [TestClass]
    public class ImagesUnitTest
    {
        [TestMethod]
        public void Index()
        {
            ImagesController controller = new ImagesController();
            ViewResult result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);
        }
    }
}
