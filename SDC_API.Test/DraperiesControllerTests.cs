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
    public class DraperiesControllerTests
    {
        private static DbContextOptions<SDCContext> dbContextOptions { get; }
        private static string connectionString = "Server = 34.73.191.28; Database=SDC;Uid=sqlserver;Password=Conestoga20";
        private SDCContext _context;
        private DraperiesController _controller;

        static DraperiesControllerTests()
        {
            dbContextOptions = new DbContextOptionsBuilder<SDCContext>()
                .UseSqlServer(connectionString)
                .Options;
        }

        //[Fact]
        //public async void Task1_GetById_Return_OkResult()
        //{
        //    //Arrange
        //    var draperyId = 1;
        //    var projectId = 1;
        //    var roomId = "Main Room";

        //    _context = new SDCContext(dbContextOptions);
        //    _controller = new DraperiesController(_context);

        //    //Act
        //    var result = await _controller.GetDrapery(draperyId, projectId, roomId);

        //    //Assert
        //    Assert.IsType<OkObjectResult>(result);
        //}

        [Fact]
        public async void Task2_GetById_Return_NotFoundResult()
        {
            //Arrange
            var draperyId = 1;
            var projectId = 1;
            var roomId = "New Room";
            _context = new SDCContext(dbContextOptions);
            _controller = new DraperiesController(_context);

            //Act
            var result = await _controller.GetDrapery(draperyId, projectId, roomId);

            //Assert
            Assert.IsType<NotFoundResult>(result);
        }

        //[Fact]
        //public async void Task3_Post_New_Drapery_FindName()
        //{
        //    //Arrange
        //    _context = new SDCContext(dbContextOptions);
        //    _controller = new DraperiesController(_context);
        //    var drapery = new Drapery()
        //    {
        //        DraperyId = 1,
        //        ProjectId = 6,
        //        RoomId = "NewRoom",
        //        TypeName ="Window",
        //        TypeValue ="High",

        //    };

        //    //Act
        //    var result = await _controller.PostDrapery(drapery);

        //    //Assert
        //    var okResult = result.Should().BeOfType<CreatedAtActionResult>().Subject;
        //    var resDrapery = okResult.Value.Should().BeAssignableTo<Drapery>().Subject;
        //    resDrapery.RoomId.Should().Be("NewRoom");

        //    //delete JayNew
        //    int draperyId = _context.Drapery.FirstOrDefault(p => p.RoomId == "NewRoom").DraperyId;
        //    int projectId = _context.Drapery.FirstOrDefault(p => p.RoomId == "NewRoom").ProjectId;
        //    string roomId = _context.Drapery.FirstOrDefault(p => p.RoomId == "NewRoom").RoomId;
        //    var resultDelete = await _controller.DeleteDrapery(draperyId, projectId, roomId);
        //}

        //[Fact]
        //public async void Task4_Put_Update_Drapery_NoContentResult()
        //{
        //    //Arrange
        //    _context = new SDCContext(dbContextOptions);
        //    _controller = new DraperiesController(_context);
        //    var draperyId = 1;
        //    var projectId = 1;
        //    var roomId = "New Room";

        //    //Act
        //    var drapery = new Drapery()
        //    {
        //        DraperyId = 1,
        //        ProjectId = 1,
        //        RoomId = "New Room",
        //        TypeName = "Door",
        //        TypeValue = "High",

        //    };
        //    var updatedData = await _controller.PutDrapery(draperyId, projectId, roomId, drapery);

        //    //Assert
        //    Assert.IsType<NoContentResult>(updatedData);
        //}

        //[Fact]
        //private async void Task5_Delete_Drapery_OkResult()
        //{
        //    //Arrange
        //    _context = new SDCContext(dbContextOptions);
        //    _controller = new DraperiesController(_context);
        //    var drapery = new Drapery()
        //    {
        //        DraperyId = 1,
        //        ProjectId = 6,
        //        RoomId = "DelRoom",
        //        TypeName = "Window",
        //        TypeValue = "High",

        //    };

        //    //Act
        //    var resultCreate = await _controller.PostDrapery(drapery);
        //    var okResult = resultCreate.Should().BeOfType<CreatedAtActionResult>().Subject;
        //    var resDrapery = okResult.Value.Should().BeAssignableTo<Drapery>().Subject;
        //    int draperyId = resDrapery.DraperyId;
        //    int projectId = resDrapery.ProjectId;
        //    string roomId = resDrapery.RoomId;

        //    var result = await _controller.DeleteDrapery(draperyId, projectId, roomId);

        //    //Assert
        //    Assert.IsType<OkObjectResult>(result);
        //}
    }
}
