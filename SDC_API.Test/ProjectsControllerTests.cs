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
    public class ProjectsControllerTests
    {
        private static DbContextOptions<SDCContext> dbContextOptions { get; }
        private static string connectionString = "Server=DESKTOP-H7TUR07;Database=SDC;Trusted_Connection=True;MultipleActiveResultSets=true";
        private SDCContext _context;
        private ProjectsController _controller;

        static ProjectsControllerTests()
        {
            dbContextOptions = new DbContextOptionsBuilder<SDCContext>()
                .UseSqlServer(connectionString)
                .Options;
        }


        //[Fact]
        //public async void Task1_GetById_Return_OkResult()
        //{
        //    //Arrange
        //    var Id = 1;
        //    _context = new SDCContext(dbContextOptions);
        //    _controller = new ProjectsController(_context);

        //    //Act
        //    var result = await _controller.GetProject(Id);

        //    //Assert
        //    Assert.IsType<OkObjectResult>(result);
        //}

        [Fact]
        public async void Task2_GetById_Return_NotFoundResult()
        {
            //Arrange
            var Id = 2;
            _context = new SDCContext(dbContextOptions);
            _controller = new ProjectsController(_context);

            //Act
            var result = await _controller.GetProject(Id);

            //Assert
            Assert.IsType<NotFoundResult>(result);
        }

        //[Fact]
        //public async void Task3_Post_New_Project_FindName()
        //{
        //    //Arrange
        //    _context = new SDCContext(dbContextOptions);
        //    _controller = new ProjectsController(_context);
        //    var project = new Project()
        //    {
        //        ProjectTag = "ConestogaTag",
        //        ClientId = 1,
        //        Status = "Y"
        //    };

        //    //Act
        //    var result = await _controller.PostProject(project);

        //    //Assert
        //    var okResult = result.Should().BeOfType<CreatedAtActionResult>().Subject;
        //    var resProject = okResult.Value.Should().BeAssignableTo<Project>().Subject;
        //    resProject.ProjectTag.Should().Be("ConestogaTag");

        //    //delete JayNew
        //    int newId = _context.Project.FirstOrDefault(p => p.ProjectTag == "ConestogaTag").ProjectId;
        //    var resultDelete = await _controller.DeleteProject(newId);
        //}

        //[Fact]
        //public async void Task4_Put_Update_Project_NoContentResult()
        //{
        //    //Arrange
        //    _context = new SDCContext(dbContextOptions);
        //    _controller = new ProjectsController(_context);
        //    int newId = 1;

        //    //Act
        //    var updateData = new Project()
        //    {
        //        ProjectId = 1,
        //        ProjectTag = "UpdateTag",
        //        ClientId = 1,
        //        Status = "Y"
        //    };
        //    var updatedData = await _controller.PutProject(newId, updateData);

        //    //Assert
        //    Assert.IsType<NoContentResult>(updatedData);
        //}

        //[Fact]
        //private async void Task5_Delete_Client_OkResult()
        //{
        //    //Arrange
        //    _context = new SDCContext(dbContextOptions);
        //    _controller = new ProjectsController(_context);
        //    var project = new Project()
        //    {
        //        ProjectTag = "PickleDelTag",
        //        ClientId = 1,
        //        Status = "N"
        //    };

        //    //Act
        //    var resultCreate = await _controller.PostProject(project);
        //    var okResult = resultCreate.Should().BeOfType<CreatedAtActionResult>().Subject;
        //    var resProject = okResult.Value.Should().BeAssignableTo<Project>().Subject;
        //    int delId = resProject.ProjectId;
        //    var result = await _controller.DeleteProject(delId);

        //    //Assert
        //    Assert.IsType<OkObjectResult>(result);
        //}

    }
}
