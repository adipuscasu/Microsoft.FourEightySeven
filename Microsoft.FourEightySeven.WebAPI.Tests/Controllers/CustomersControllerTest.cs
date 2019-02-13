using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.FourEightySeven.WebAPI.Controllers;

namespace Microsoft.FourEightySeven.WebAPI.Tests.Controllers
{
    [TestClass]
    public class CustomersControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            CustomersController controller = new CustomersController();

            // Act
            ViewResult result = controller.GetCustomers(1) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
