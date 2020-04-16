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
    public class PurchaseStocksControllerTests
    {
        private static DbContextOptions<SDCContext> dbContextOptions { get; }
        private static string connectionString = "Server=localhost;Database=SDC;Trusted_Connection=True;MultipleActiveResultSets=true";
        private SDCContext _context;
        private PurchaseStocksController _controller;

        static PurchaseStocksControllerTests()
        {
            dbContextOptions = new DbContextOptionsBuilder<SDCContext>()
                .UseSqlServer(connectionString)
                .Options;
        }

        //[Fact]
        //public async void Task1_GetById_Return_OkResult()
        //{
        //    //Arrange
        //    var projectId = 1;
        //    var orderId = 1;
        //    var productId = "B1OPK";

        //    _context = new SDCContext(dbContextOptions);
        //    _controller = new PurchaseStocksController(_context);

        //    //Act
        //    var result = await _controller.GetPurchaseStock(projectId, orderId, productId);

        //    //Assert
        //    Assert.IsType<OkObjectResult>(result);
        //}

        [Fact]
        public async void Task2_GetById_Return_NotFoundResult()
        {
            //Arrange
            var projectId = 2;
            var orderId = 1;
            var productId = "B1OPK";
            _context = new SDCContext(dbContextOptions);
            _controller = new PurchaseStocksController(_context);

            //Act
            var result = await _controller.GetPurchaseStock(projectId, orderId, productId);

            //Assert
            Assert.IsType<NotFoundResult>(result);
        }

        //[Fact]
        //public async void Task3_Post_New_PurchaseStock_FindName()
        //{
        //    //Arrange
        //    _context = new SDCContext(dbContextOptions);
        //    _controller = new PurchaseStocksController(_context);
        //    var purchaseStock = new PurchaseStock()
        //    {
        //        ProjectId = 6,
        //        OrderId = 1,
        //        ProductId = "P001CN"
        //    };

        //    //Act
        //    var result = await _controller.PostPurchaseStock(purchaseStock);

        //    //Assert
        //    var okResult = result.Should().BeOfType<CreatedAtActionResult>().Subject;
        //    var resStock = okResult.Value.Should().BeAssignableTo<PurchaseStock>().Subject;
        //    resStock.ProductId.Should().Be("P001CN");

        //    //delete JayNew
        //    int projectId = _context.PurchaseStock.FirstOrDefault(p => p.ProductId == "P001CN").ProjectId;
        //    int orderId = _context.PurchaseStock.FirstOrDefault(p => p.ProductId == "P001CN").OrderId;
        //    string productId = _context.PurchaseStock.FirstOrDefault(p => p.ProductId == "P001CN").ProductId;
        //    var resultDelete = await _controller.DeletePurchaseStock(projectId, orderId, productId);
        //}

        //[Fact]
        //public async void Task4_Put_Update_PurchaseStock_NoContentResult()
        //{
        //    //Arrange
        //    _context = new SDCContext(dbContextOptions);
        //    _controller = new PurchaseStocksController(_context);
        //    var projectId = 1;
        //    var orderId = 1;
        //    var productId = "B1OPK";

        //    //Act
        //    var purchaseStock = new PurchaseStock()
        //    {
        //        ProjectId = 6,
        //        OrderId = 1,
        //        ProductId = "P001CN",
        //        Dimension = "Length 22m"
        //    };
        //    var updatedData = await _controller.PutPurchaseStock(projectId, orderId, productId, purchaseStock);

        //    //Assert
        //    Assert.IsType<NoContentResult>(updatedData);
        //}

        //[Fact]
        //private async void Task5_Delete_PurchaseStock_OkResult()
        //{
        //    //Arrange
        //    _context = new SDCContext(dbContextOptions);
        //    _controller = new PurchaseStocksController(_context);
        //    var purchaseStock = new PurchaseStock()
        //    {
        //        ProjectId = 6,
        //        OrderId = 2,
        //        ProductId = "P001DL"
        //    };

        //    //Act
        //    var resultCreate = await _controller.PostPurchaseStock(purchaseStock);
        //    var okResult = resultCreate.Should().BeOfType<CreatedAtActionResult>().Subject;
        //    var resStock = okResult.Value.Should().BeAssignableTo<PurchaseStock>().Subject;
        //    int projectId = resStock.ProjectId;
        //    int orderId = resStock.OrderId;
        //    string productId = resStock.ProductId;

        //    var result = await _controller.DeletePurchaseStock(projectId, orderId, productId);

        //    //Assert
        //    Assert.IsType<OkObjectResult>(result);
        //}
    }
}
