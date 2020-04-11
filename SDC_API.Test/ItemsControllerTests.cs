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
    public class ItemsControllerTests
    {
        private static DbContextOptions<SDCContext> dbContextOptions { get; }
        private static string connectionString = "Server=DESKTOP-H7TUR07;Database=SDC;Trusted_Connection=True;MultipleActiveResultSets=true";
        private SDCContext _context;
        private ItemsController _controller;

        static ItemsControllerTests()
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
        //    var roomId = "Main Room";
        //    var productId = "P1K";

        //    _context = new SDCContext(dbContextOptions);
        //    _controller = new ItemsController(_context);

        //    //Act
        //    var result = await _controller.GetItems(projectId, roomId, productId);

        //    //Assert
        //    Assert.IsType<OkObjectResult>(result);
        //}

        [Fact]
        public async void Task2_GetById_Return_NotFoundResult()
        {
            //Arrange
            var projectId = 2;
            var roomId = "Main Room";
            var productId = "P1K";
            _context = new SDCContext(dbContextOptions);
            _controller = new ItemsController(_context);

            //Act
            var result = await _controller.GetItems(projectId, roomId, productId);

            //Assert
            Assert.IsType<NotFoundResult>(result);
        }

        //[Fact]
        //public async void Task3_Post_New_Item_FindName()
        //{
        //    //Arrange
        //    _context = new SDCContext(dbContextOptions);
        //    _controller = new ItemsController(_context);
        //    var item = new Items()
        //    {
        //        ProjectId = 1,
        //        RoomId = "NewRoom",
        //        ProductId = "P1K",
        //        SupplierId = 1
        //    };

        //    //Act
        //    var result = await _controller.PostItems(item);

        //    //Assert
        //    var okResult = result.Should().BeOfType<CreatedAtActionResult>().Subject;
        //    var resItems = okResult.Value.Should().BeAssignableTo<Items>().Subject;
        //    resItems.RoomId.Should().Be("NewRoom");

        //    //delete JayNew
        //    int projectId = _context.Items.FirstOrDefault(p => p.RoomId == "NewRoom").ProjectId;
        //    string roomId = _context.Items.FirstOrDefault(p => p.RoomId == "NewRoom").RoomId;
        //    string productId = _context.Items.FirstOrDefault(p => p.RoomId == "NewRoom").ProductId;
        //    var resultDelete = await _controller.DeleteItems(projectId, roomId, productId);
        //}

        //[Fact]
        //public async void Task4_Put_Update_Item_NoContentResult()
        //{
        //    //Arrange
        //    _context = new SDCContext(dbContextOptions);
        //    _controller = new ItemsController(_context);
        //    var projectId = 1;
        //    var roomId = "Main Room";
        //    var productId = "P1K";

        //    //Act
        //    var item = new Items()
        //    {
        //        ProjectId = 1,
        //        RoomId = "NewRoom",
        //        ProductId = "P1K",
        //        SupplierId = 1,
        //        Dimension = "length 2m"
        //    };
        //    var updatedData = await _controller.PutItems(projectId, roomId, productId, item);

        //    //Assert
        //    Assert.IsType<NoContentResult>(updatedData);
        //}

        //[Fact]
        //private async void Task5_Delete_Item_OkResult()
        //{
        //    //Arrange
        //    _context = new SDCContext(dbContextOptions);
        //    _controller = new ItemsController(_context);
        //    var item = new Items()
        //    {
        //        ProjectId = 1,
        //        RoomId = "NewRoom",
        //        ProductId = "P1K",
        //        SupplierId = 1
        //    };

        //    //Act
        //    var resultCreate = await _controller.PostItems(item);
        //    var okResult = resultCreate.Should().BeOfType<CreatedAtActionResult>().Subject;
        //    var resItems = okResult.Value.Should().BeAssignableTo<Items>().Subject;
        //    int projectId = resItems.ProjectId;
        //    string roomId = resItems.RoomId;
        //    string productId = resItems.ProductId;

        //    var result = await _controller.DeleteItems(projectId, roomId, productId);

        //    //Assert
        //    Assert.IsType<OkObjectResult>(result);
        //}

    }
}
