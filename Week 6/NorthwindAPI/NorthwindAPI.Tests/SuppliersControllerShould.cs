using Moq;
using NorthwindAPI.Controller;
using NorthwindAPI.Models.DTO;
using NorthwindAPI.Models;
using NorthwindAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindAPI.Tests
{
    internal class SuppliersControllerShould
    {
        [Category("Happy Path")]
        [Category("GetSuppliers")]
        [Test]
        public async Task GetSuppliers_WhenThereAreSuppliers_ReturnsListOfSupplierDTOs()
        {
            var mockService = Mock.Of<INorthwindService<Supplier>>();
            List<Supplier> suppliers = new List<Supplier> { Mock.Of<Supplier>(s => s.Products == Mock.Of<List<Product>>()) };
            Mock
            .Get(mockService)
            .Setup(sc => sc.GetAllAsync().Result)
            .Returns(suppliers);

            var sut = new SuppliersController(mockService);
            var result = await sut.GetSuppliers();
            Assert.That(result.Value, Is.InstanceOf<IEnumerable<SupplierDTO>>());
        }
    }
}
