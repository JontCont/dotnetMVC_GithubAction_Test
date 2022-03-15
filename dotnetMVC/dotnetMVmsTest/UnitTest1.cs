using dotnetMVC.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotnetMVmsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            HomeController homeController = new HomeController();
            Assert.AreNotEqual(homeController.Get_String(), "");
        }
    }
}
