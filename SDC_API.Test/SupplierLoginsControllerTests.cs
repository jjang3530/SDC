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
    public class SupplierLoginsControllerTests
    {
        private static DbContextOptions<SDCContext> dbContextOptions { get; }
        private static string connectionString = "Server=localhost;Database=SDC;Trusted_Connection=True;MultipleActiveResultSets=true";
        private SDCContext _context;
        private SupplierLoginsController _controller;

        static SupplierLoginsControllerTests()
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
            _controller = new SupplierLoginsController(_context);

            //Act
            var result = await _controller.GetSupplierLogin(Id);

            //Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async void Task2_GetById_Return_NotFoundResult()
        {
            //Arrange
            var Id = 82;
            _context = new SDCContext(dbContextOptions);
            _controller = new SupplierLoginsController(_context);

            //Act
            var result = await _controller.GetSupplierLogin(Id);

            //Assert
            Assert.IsType<NotFoundResult>(result);
        }

        //[Fact]
        //public async void Task3_Post_NewSupplierLogin_JobTitle()
        //{
        //    //Arrange
        //    _context = new SDCContext(dbContextOptions);
        //    _controller = new SupplierLoginsController(_context);
        //    var supplierLogin = new SupplierLogin()
        //    {
        //        Website = "https://www.conestogac.on.ca",
        //    };

        //    //Act
        //    var result = await _controller.PostSupplierLogin(supplierLogin);

        //    //Assert
        //    var okResult = result.Should().BeOfType<CreatedAtActionResult>().Subject;
        //    var resClient = okResult.Value.Should().BeAssignableTo<SupplierLogin>().Subject;
        //    resClient.Website.Should().Be("https://www.conestogac.on.ca");

        //    ////delete JayNew
        //    //int newId = _context.SupplierLogin.FirstOrDefault(p => p.Website == "https://www.conestogac.on.ca").SupplierId;
        //    //var resultDelete = await _controller.DeleteSupplierLogin(newId);
        //}

        //[Fact]
        //public async void Task4_Put_Update_SupplierLogin_NoContentResult()
        //{
        //    //Arrange
        //    _context = new SDCContext(dbContextOptions);
        //    _controller = new SupplierLoginsController(_context);
        //    int newId = 61;

        //    //Act
        //    var supplierLogin = new SupplierLogin()
        //    {
        //        SupplierId = newId,
        //        Website = "https://www.google.ca"
        //    };
        //    var updatedData = await _controller.PutSupplierLogin(newId, supplierLogin);

        //    //Assert
        //    Assert.IsType<NoContentResult>(updatedData);
        //}

        //[Fact]
        //private async void Task5_Delete_SupplierLogin_OkResult()
        //{
        //    //Arrange
        //    _context = new SDCContext(dbContextOptions);
        //    _controller = new SupplierLoginsController(_context);
        //    var supplierLogin = new SupplierLogin()
        //    {
        //        Website = "https://www.nba.com",
        //    };

        //    //Act
        //    var resultCreate = await _controller.PostSupplierLogin(supplierLogin);
        //    var okResult = resultCreate.Should().BeOfType<CreatedAtActionResult>().Subject;
        //    var resClient = okResult.Value.Should().BeAssignableTo<SupplierLogin>().Subject;
        //    int delId = resClient.SupplierId;
        //    var result = await _controller.DeleteSupplierLogin(delId);

        //    //Assert
        //    Assert.IsType<OkObjectResult>(result);
        //}
    }
}

