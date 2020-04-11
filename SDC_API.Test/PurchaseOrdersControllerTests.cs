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
    public class PurchaseOrdersControllerTests
    {
        private static DbContextOptions<SDCContext> dbContextOptions { get; }
        private static string connectionString = "Server=DESKTOP-H7TUR07;Database=SDC;Trusted_Connection=True;MultipleActiveResultSets=true";
        private SDCContext _context;
        private PurchaseOrdersController _controller;

        static PurchaseOrdersControllerTests()
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
        //    _context = new SDCContext(dbContextOptions);
        //    _controller = new PurchaseOrdersController(_context);

        //    //Act
        //    var result = await _controller.GetPurchaseOrder(projectId, orderId);

        //    //Assert
        //    Assert.IsType<OkObjectResult>(result);
        //}

        [Fact]
        public async void Task2_GetById_Return_NotFoundResult()
        {
            //Arrange
            var projectId = 2;
            var orderId = 2;
            _context = new SDCContext(dbContextOptions);
            _controller = new PurchaseOrdersController(_context);

            //Act
            var result = await _controller.GetPurchaseOrder(projectId, orderId);

            //Assert
            Assert.IsType<NotFoundResult>(result);
        }

        //[Fact]
        //public async void Task3_Post_New_PurchaseOrder_FindName()
        //{
        //    //Arrange
        //    _context = new SDCContext(dbContextOptions);
        //    _controller = new PurchaseOrdersController(_context);
        //    var purchaseOrder = new PurchaseOrder()
        //    {
        //        ProjectId = 1,
        //        OrderId = 1,
        //        SupplierId = 1,
        //        ShippingPlace = "Conestoga",
        //        ShippingAddress = "Waterloo"
        //    };

        //    //Act
        //    var result = await _controller.PostPurchaseOrder(purchaseOrder);

        //    //Assert
        //    var okResult = result.Should().BeOfType<CreatedAtActionResult>().Subject;
        //    var resPurchaseOrder = okResult.Value.Should().BeAssignableTo<PurchaseOrder>().Subject;
        //    resPurchaseOrder.ShippingPlace.Should().Be("Conestoga");

        //    //delete JayNew
        //    int projectId = _context.PurchaseOrder.FirstOrDefault(p => p.ShippingPlace == "Conestoga").ProjectId;
        //    int orderId = _context.PurchaseOrder.FirstOrDefault(p => p.ShippingPlace == "Conestoga").OrderId;
        //    var resltDelete = await _controller.DeletePurchaseOrder(projectId, orderId);
        //}

        //[Fact]
        //public async void Task4_Put_Update_PurchaseOrder_NoContentResult()
        //{
        //    //Arrange
        //    _context = new SDCContext(dbContextOptions);
        //    _controller = new PurchaseOrdersController(_context);
        //    var projectId = 1;
        //    var orderId = 1;

        //    //Act
        //    var purchaseOrder = new PurchaseOrder()
        //    {
        //        ProjectId = 1,
        //        OrderId = 1,
        //        SupplierId = 1,
        //        ShippingPlace = "PickleTeam",
        //        ShippingAddress = "KItchener"
        //    };
        //    var updatedData = await _controller.PutPurchaseOrder(projectId, orderId, purchaseOrder);

        //    //Assert
        //    Assert.IsType<NoContentResult>(updatedData);
        //}

        //[Fact]
        //private async void Task5_Delete_PurchaseOrder_OkResult()
        //{
        //    //Arrange
        //    _context = new SDCContext(dbContextOptions);
        //    _controller = new PurchaseOrdersController(_context);
        //    var purchaseOrder = new PurchaseOrder()
        //    {
        //        ProjectId = 1,
        //        OrderId = 1,
        //        SupplierId = 1,
        //        ShippingPlace = "DelTeam",
        //        ShippingAddress = "KItchener"
        //    };

        //    //Act
        //    var resultCreate = await _controller.PostPurchaseOrder(purchaseOrder);
        //    var okResult = resultCreate.Should().BeOfType<CreatedAtActionResult>().Subject;
        //    var resPurchaseOrder = okResult.Value.Should().BeAssignableTo<PurchaseOrder>().Subject;
        //    int projectId = resPurchaseOrder.ProjectId;
        //    int orderId = resPurchaseOrder.OrderId;

        //    var result = await _controller.DeletePurchaseOrder(projectId, orderId);

        //    //Assert
        //    Assert.IsType<OkObjectResult>(result);
        //}

    }
}
