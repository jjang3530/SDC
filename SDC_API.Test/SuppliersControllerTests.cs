using Xunit;
using SDC_API.Controllers;
using Microsoft.AspNetCore.Mvc;
using SDC_API.Models;
using Microsoft.EntityFrameworkCore;
using FluentAssertions;
using System;
using System.Linq;

namespace SDC_API.Test
{
    public class SuppliersControllerTests
    {
        private static DbContextOptions<SDCContext> dbContextOptions { get; }
        private static string connectionString = "Server=localhost;Database=SDC;Trusted_Connection=True;MultipleActiveResultSets=true";
        private SDCContext _context;
        private SuppliersController _controller;

        static SuppliersControllerTests()
        {
            dbContextOptions = new DbContextOptionsBuilder<SDCContext>()
                .UseSqlServer(connectionString)
                .Options;
        }


        [Fact]
        public async void Task1_GetById_Return_OkResult()
        {
            //Arrange
            var Id = 1;
            _context = new SDCContext(dbContextOptions);
            _controller = new SuppliersController(_context);

            //Act
            var result = await _controller.GetSupplier(Id);

            //Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async void Task2_GetById_Return_NotFoundResult()
        {
            //Arrange
            var Id = 82;
            _context = new SDCContext(dbContextOptions);
            _controller = new SuppliersController(_context);

            //Act
            var result = await _controller.GetSupplier(Id);

            //Assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async void Task3_Post_NewSupplier_JobTitle()
        {
            //Arrange
            _context = new SDCContext(dbContextOptions);
            _controller = new SuppliersController(_context);
            var supplier = new Supplier()
            {
                Company = "Pickle",
            };

            //Act
            var result = await _controller.PostSupplier(supplier);

            //Assert
            var okResult = result.Should().BeOfType<CreatedAtActionResult>().Subject;
            var resClient = okResult.Value.Should().BeAssignableTo<Supplier>().Subject;
            resClient.Company.Should().Be("Pickle");

            //delete JayNew
            int newId = _context.Supplier.FirstOrDefault(p => p.Company == "Pickle").SupplierId;
            var resultDelete = await _controller.DeleteSupplier(newId);
        }

        [Fact]
        public async void Task4_Put_Update_Supplier_NoContentResult()
        {
            //Arrange
            _context = new SDCContext(dbContextOptions);
            _controller = new SuppliersController(_context);
            int newId = 59;

            //Act
            var supplier = new Supplier()
            {
                SupplierId = newId,
                Company = "Update Zuo"
            };
            var updatedData = await _controller.PutSupplier(newId, supplier);

            //Assert
            Assert.IsType<NoContentResult>(updatedData);
        }

        [Fact]
        private async void Task5_Delete_Supplier_OkResult()
        {
            //Arrange
            _context = new SDCContext(dbContextOptions);
            _controller = new SuppliersController(_context);
            var supplier = new Supplier()
            {
                Company = "Kitchener",
            };

            //Act
            var resultCreate = await _controller.PostSupplier(supplier);
            var okResult = resultCreate.Should().BeOfType<CreatedAtActionResult>().Subject;
            var resClient = okResult.Value.Should().BeAssignableTo<Supplier>().Subject;
            int delId = resClient.SupplierId;
            var result = await _controller.DeleteSupplier(delId);

            //Assert
            Assert.IsType<OkObjectResult>(result);
        }
    }
}
