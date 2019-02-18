using Microsoft.VisualStudio.TestTools.UnitTesting;
using rsoil1;
using rsoil1.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace UnitTestL1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MultTest1()
        {
            HomeController controller = new HomeController();
            var result = controller.Get(2, 4).Value;
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void MultTest2()
        {
            HomeController controller = new HomeController();
            var result = controller.Get(0, 0).Value;
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void MultTest3()
        {
            HomeController controller = new HomeController();
            var result = controller.Get(2, null).Value;
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void MultTest4()
        {
            HomeController controller = new HomeController();
            var result = controller.Get(null, 4).Value;
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void MultTest5()
        {
            HomeController controller = new HomeController();
            var result = controller.Get(null, null).Value;
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void MultTest6()
        {
            HomeController controller = new HomeController();
            var result = controller.Get(-2, 4).Value;
            Assert.AreEqual(-8, result);
        }

        [TestMethod]
        public void MultTest7()
        {
            HomeController controller = new HomeController();
            var result = controller.Get(-2, -4).Value;
            Assert.AreEqual(8, result);
        }
    }
}
