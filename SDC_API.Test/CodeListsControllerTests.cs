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
    public class CodeListsControllerTests
    {
        //private static DbContextOptions<SDCContext> dbContextOptions { get; }
        //private static string connectionString = "Server = 34.73.191.28; Database=SDC;Uid=sqlserver;Password=Conestoga20";
        //private SDCContext _context;
        //private CodeListsController _controller;

        //static CodeListsControllerTests()
        //{
        //    dbContextOptions = new DbContextOptionsBuilder<SDCContext>()
        //        .UseSqlServer(connectionString)
        //        .Options;
        //}


        //[Fact]
        //public async void Task1_GetById_Return_OkResult()
        //{
        //    //Arrange
        //    var Id = 1;
        //    _context = new SDCContext(dbContextOptions);
        //    _controller = new CodeListsController(_context);

        //    //Act
        //    var result = await _controller.GetCodeList(Id);

        //    //Assert
        //    Assert.IsType<OkObjectResult>(result);
        //}

        //[Fact]
        //public async void Task2_GetById_Return_NotFoundResult()
        //{
        //    //Arrange
        //    var Id = 32;
        //    _context = new SDCContext(dbContextOptions);
        //    _controller = new CodeListsController(_context);

        //    //Act
        //    var result = await _controller.GetCodeList(Id);

        //    //Assert
        //    Assert.IsType<NotFoundResult>(result);
        //}

        //[Fact]
        //public async void Task3_Post_NewCategory_FindName()
        //{
        //    //Arrange
        //    _context = new SDCContext(dbContextOptions);
        //    _controller = new CodeListsController(_context);
        //    var category = new CodeList()
        //    {
        //        CodeName = "NewPickle"
        //    };

        //    //Act
        //    var result = await _controller.PostCodeList(category);

        //    //Assert
        //    var okResult = result.Should().BeOfType<CreatedAtActionResult>().Subject;
        //    var resClient = okResult.Value.Should().BeAssignableTo<CodeList>().Subject;
        //    resClient.CodeName.Should().Be("NewPickle");

        //    //delete JayNew
        //    int newId = _context.CodeList.FirstOrDefault(p => p.CodeName == "NewPickle").CodeId;
        //    var resultDelete = await _controller.DeleteCodeList(newId);
        //}

        //[Fact]
        //public async void Task4_Put_UpdateClient_NoContentResult()
        //{
        //    //Arrange
        //    _context = new SDCContext(dbContextOptions);
        //    _controller = new CodeListsController(_context);
        //    int newId = 26;

        //    //Act
        //    var code = new CodeList()
        //    {
        //        CodeId = newId,
        //        CodeName = "Update Pickle"
        //    };
        //    var updatedData = await _controller.PutCodeList(newId, code);

        //    //Assert
        //    Assert.IsType<NoContentResult>(updatedData);
        //}

        //[Fact]
        //private async void Task5_Delete_Client_OkResult()
        //{
        //    //Arrange
        //    _context = new SDCContext(dbContextOptions);
        //    _controller = new CodeListsController(_context);
        //    var code = new CodeList()
        //    {
        //        CodeName = "New and Del Pickle",
        //    };

        //    //Act
        //    var resultCreate = await _controller.PostCodeList(code);
        //    var okResult = resultCreate.Should().BeOfType<CreatedAtActionResult>().Subject;
        //    var resClient = okResult.Value.Should().BeAssignableTo<CodeList>().Subject;
        //    int delId = resClient.CodeId;
        //    var result = await _controller.DeleteCodeList(delId);

        //    //Assert
        //    Assert.IsType<OkObjectResult>(result);
        //}
    }
}
