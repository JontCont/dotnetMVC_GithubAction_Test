using Microsoft.VisualStudio.TestTools.UnitTesting;
using dotnetMVC.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetMVC.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        [TestMethod()]
        public void Get_StringTest()
        {
            HomeController homeController = new HomeController();
            Assert.AreNotEqual(homeController.Get_String(), "Test");
        }
    }
}