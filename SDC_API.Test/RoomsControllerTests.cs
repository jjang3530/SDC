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
    public class RoomsControllerTests
    {
        private static DbContextOptions<SDCContext> dbContextOptions { get; }
        private static string connectionString = "Server=localhost;Database=SDC;Trusted_Connection=True;MultipleActiveResultSets=true";
        private SDCContext _context;
        private RoomsController _controller;

        static RoomsControllerTests()
        {
            dbContextOptions = new DbContextOptionsBuilder<SDCContext>()
                .UseSqlServer(connectionString)
                .Options;
        }


        //[Fact]
        //public async void Task1_GetById_Return_OkResult()
        //{
        //    //Arrange
        //    var roomId = "main room";
        //    var projectId = 1;

        //    _context = new SDCContext(dbContextOptions);
        //    _controller = new RoomsController(_context);

        //    //Act
        //    var result = await _controller.GetRoom(roomId, projectId);

        //    //Assert
        //    Assert.IsType<OkObjectResult>(result);
        //}

        [Fact]
        public async void Task2_GetById_Return_NotFoundResult()
        {
            //Arrange
            var roomId = "main room";
            var projectId = 2;
            _context = new SDCContext(dbContextOptions);
            _controller = new RoomsController(_context);

            //Act
            var result = await _controller.GetRoom(roomId, projectId);

            //Assert
            Assert.IsType<NotFoundResult>(result);
        }

        //[Fact]
        //public async void Task3_Post_New_Room_FindName()
        //{
        //    //Arrange
        //    _context = new SDCContext(dbContextOptions);
        //    _controller = new RoomsController(_context);
        //    var room = new Room()
        //    {
        //        RoomId = "New Room",
        //        ProjectId = 6
        //    };

        //    //Act
        //    var result = await _controller.PostRoom(room);

        //    //Assert
        //    var okResult = result.Should().BeOfType<CreatedAtActionResult>().Subject;
        //    var resRoom = okResult.Value.Should().BeAssignableTo<Room>().Subject;
        //    resRoom.RoomId.Should().Be("New Room");

        //    //delete JayNew
        //    string roomId = _context.Room.FirstOrDefault(p => p.RoomId == "New Room").RoomId;
        //    int projectId = _context.Room.FirstOrDefault(p => p.RoomId == "New Room").ProjectId;
        //    var resultDelete = await _controller.DeleteRoom(roomId, projectId);
        //}

        //[Fact]
        //public async void Task4_Put_Update_Room_NoContentResult()
        //{
        //    //Arrange
        //    _context = new SDCContext(dbContextOptions);
        //    _controller = new RoomsController(_context);
        //    var roomId = "main room";
        //    var projectId = 2;

        //    //Act
        //    var room = new Room()
        //    {
        //        RoomId = "New Room",
        //        ProjectId = 1,
        //        FloorCeiling = 2.35m
        //    };

        //    var updatedData = await _controller.PutRoom(roomId, projectId, room);

        //    //Assert
        //    Assert.IsType<NoContentResult>(updatedData);
        //}

        //[Fact]
        //private async void Task5_Delete_Room_OkResult()
        //{
        //    //Arrange
        //    _context = new SDCContext(dbContextOptions);
        //    _controller = new RoomsController(_context);
        //    var room = new Room()
        //    {
        //        RoomId = "Del Room",
        //        ProjectId = 1
        //    };

        //    //Act
        //    var resultCreate = await _controller.PostRoom(room);
        //    var okResult = resultCreate.Should().BeOfType<CreatedAtActionResult>().Subject;
        //    var resRoom = okResult.Value.Should().BeAssignableTo<Room>().Subject;
        //    string delRoomId = resRoom.RoomId;
        //    int delProjectId = resRoom.ProjectId;

        //    var result = await _controller.DeleteRoom(delRoomId, delProjectId);

        //    //Assert
        //    Assert.IsType<OkObjectResult>(result);
        //}
    }
}
