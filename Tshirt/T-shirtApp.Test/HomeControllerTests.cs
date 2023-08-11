using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T_shirt.Models.Models;
using TshirtWeb.Areas.Customer.Controllers;

namespace T_shirtApp.Test
{
    public class HomeControllerTests
    {
        [Test]
        public void IndexActionModelIsComplete()
        {
            // Arrange
            var controller = new HomeController(null, null);
            Product[] products = new Product[] {
            new Product { TshirtName = "T-shirt name One", ListPrice = 275 },
            new Product { TshirtName = "T-shirt name One", ListPrice = 48.95}
             };
            // Act
            var model = (controller.Index() as ViewResult)?.ViewData.Model
            as IEnumerable<Product>;
            // Assert
            Assert.AreEqual(products, model,
            Comparer.Get<Product>((p1, p2) => p1?.TshirtName == p2?.TshirtName
            && p1?.ListPrice == p2?.ListPrice));
        }
    }
}
