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
    public class CodeCategoriesControllerTests
    {
        private static DbContextOptions<SDCContext> dbContextOptions { get; }
        private static string connectionString = "Server = 34.73.191.28; Database=SDC;Uid=sqlserver;Password=Conestoga20";
        private SDCContext _context;
        private CodeCategoriesController _controller;

        static CodeCategoriesControllerTests()
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
            _controller = new CodeCategoriesController(_context);

            //Act
            var result = await _controller.GetCodeCategory(Id);

            //Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async void Task2_GetById_Return_NotFoundResult()
        {
            //Arrange
            var Id = 32;
            _context = new SDCContext(dbContextOptions);
            _controller = new CodeCategoriesController(_context);

            //Act
            var result = await _controller.GetCodeCategory(Id);

            //Assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async void Task3_Post_NewCategory_FindName()
        {
            //Arrange
            _context = new SDCContext(dbContextOptions);
            _controller = new CodeCategoriesController(_context);
            var category = new CodeCategory()
            {
                CategoryName = "NewPickle",
            };

            //Act
            var result = await _controller.PostCodeCategory(category);

            //Assert
            var okResult = result.Should().BeOfType<CreatedAtActionResult>().Subject;
            var resClient = okResult.Value.Should().BeAssignableTo<CodeCategory>().Subject;
            resClient.CategoryName.Should().Be("NewPickle");

            //delete JayNew
            int newId = _context.CodeCategory.FirstOrDefault(p => p.CategoryName == "NewPickle").CategoryId;
            var resultDelete = await _controller.DeleteCodeCategory(newId);
        }

        [Fact]
        public async void Task4_Put_Update_Category_NoContentResult()
        {
            //Arrange
            _context = new SDCContext(dbContextOptions);
            _controller = new CodeCategoriesController(_context);
            int newId = 26;

            //Act
            var category = new CodeCategory()
            {
                CategoryId = newId,
                CategoryName = "Update Pickle"
            };
            var updatedData = await _controller.PutCodeCategory(newId, category);

            //Assert
            Assert.IsType<NoContentResult>(updatedData);
        }

        [Fact]
        private async void Task5_Delete_Category_OkResult()
        {
            //Arrange
            _context = new SDCContext(dbContextOptions);
            _controller = new CodeCategoriesController(_context);
            var category = new CodeCategory()
            {
                CategoryName = "New and Del Pickle",
            };

            //Act
            var resultCreate = await _controller.PostCodeCategory(category);
            var okResult = resultCreate.Should().BeOfType<CreatedAtActionResult>().Subject;
            var resClient = okResult.Value.Should().BeAssignableTo<CodeCategory>().Subject;
            int delId = resClient.CategoryId;
            var result = await _controller.DeleteCodeCategory(delId);

            //Assert
            Assert.IsType<OkObjectResult>(result);
        }
    }
}
