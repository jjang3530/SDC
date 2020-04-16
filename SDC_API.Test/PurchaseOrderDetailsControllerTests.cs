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
    public class PurchaseOrderDetailsControllerTests
    {
        private static DbContextOptions<SDCContext> dbContextOptions { get; }
        private static string connectionString = "Server=localhost;Database=SDC;Trusted_Connection=True;MultipleActiveResultSets=true";
        private SDCContext _context;
        private PurchaseOrderdetailsController _controller;

        static PurchaseOrderDetailsControllerTests()
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
        //    _controller = new PurchaseOrderdetailsController(_context);

        //    //Act
        //    var result = await _controller.GetPurchaseOrderdetail(projectId, orderId, productId);

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
            _controller = new PurchaseOrderdetailsController(_context);

            //Act
            var result = await _controller.GetPurchaseOrderdetail(projectId, orderId, productId);

            //Assert
            Assert.IsType<NotFoundResult>(result);
        }

        //[Fact]
        //public async void Task3_Post_New_PurchaseOrderDetail_FindName()
        //{
        //    //Arrange
        //    _context = new SDCContext(dbContextOptions);
        //    _controller = new PurchaseOrderdetailsController(_context);
        //    var purchaseOrderdetail = new PurchaseOrderdetail()
        //    {
        //        ProjectId = 6,
        //        OrderId = 1,
        //        ProductId = "P001CN"
        //    };

        //    //Act
        //    var result = await _controller.PostPurchaseOrderdetail(purchaseOrderdetail);

        //    //Assert
        //    var okResult = result.Should().BeOfType<CreatedAtActionResult>().Subject;
        //    var resDetail = okResult.Value.Should().BeAssignableTo<PurchaseOrderdetail>().Subject;
        //    resDetail.ProductId.Should().Be("P001CN");

        //    //delete JayNew
        //    int projectId = _context.PurchaseOrderdetail.FirstOrDefault(p => p.ProductId == "P001CN").ProjectId;
        //    int orderId = _context.PurchaseOrderdetail.FirstOrDefault(p => p.ProductId == "P001CN").OrderId;
        //    string productId = _context.PurchaseOrderdetail.FirstOrDefault(p => p.ProductId == "P001CN").ProductId;
        //    var resultDelete = await _controller.DeletePurchaseOrderdetail(projectId, orderId, productId);
        //}

        //[Fact]
        //public async void Task4_Put_Update_PurchaseOrderDetail_NoContentResult()
        //{
        //    //Arrange
        //    _context = new SDCContext(dbContextOptions);
        //    _controller = new PurchaseOrderdetailsController(_context);
        //    var projectId = 1;
        //    var orderId = 1;
        //    var productId = "B1OPK";

        //    //Act
        //    var purchaseOrderdetail = new PurchaseOrderdetail()
        //    {
        //        ProjectId = 6,
        //        OrderId = 1,
        //        ProductId = "P001CN",
        //        Dimension = "Length 22m"
        //    };
        //    var updatedData = await _controller.PutPurchaseOrderdetail(projectId, orderId, productId, purchaseOrderdetail);

        //    //Assert
        //    Assert.IsType<NoContentResult>(updatedData);
        //}

        //[Fact]
        //private async void Task5_Delete_PurchaseOrderDetail_OkResult()
        //{
        //    //Arrange
        //    _context = new SDCContext(dbContextOptions);
        //    _controller = new PurchaseOrderdetailsController(_context);
        //    var purchaseOrderdetail = new PurchaseOrderdetail()
        //    {
        //        ProjectId = 6,
        //        OrderId = 2,
        //        ProductId = "P001DL"
        //    };

        //    //Act
        //    var resultCreate = await _controller.PostPurchaseOrderdetail(purchaseOrderdetail);
        //    var okResult = resultCreate.Should().BeOfType<CreatedAtActionResult>().Subject;
        //    var resDetail = okResult.Value.Should().BeAssignableTo<PurchaseOrderdetail>().Subject;
        //    int projectId = resDetail.ProjectId;
        //    int orderId = resDetail.OrderId;
        //    string productId = resDetail.ProductId;

        //    var result = await _controller.DeletePurchaseOrderdetail(projectId, orderId, productId);

        //    //Assert
        //    Assert.IsType<OkObjectResult>(result);
        //}
    }
}
