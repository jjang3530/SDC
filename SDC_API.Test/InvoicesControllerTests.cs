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
    public class InvoicesControllerTests
    {
        private static DbContextOptions<SDCContext> dbContextOptions { get; }
        private static string connectionString = "Server=localhost;Database=SDC;Trusted_Connection=True;MultipleActiveResultSets=true";
        private SDCContext _context;
        private InvoicesController _controller;

        static InvoicesControllerTests()
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
        //    _controller = new InvoicesController(_context);

        //    //Act
        //    var result = await _controller.GetInvoice(Id);

        //    //Assert
        //    Assert.IsType<OkObjectResult>(result);
        //}

        [Fact]
        public async void Task2_GetById_Return_NotFoundResult()
        {
            //Arrange
            var Id = 2;
            _context = new SDCContext(dbContextOptions);
            _controller = new InvoicesController(_context);

            //Act
            var result = await _controller.GetInvoice(Id);

            //Assert
            Assert.IsType<NotFoundResult>(result);
        }

        //[Fact]
        //public async void Task3_Post_NewInvoice_FindName()
        //{
        //    //Arrange
        //    _context = new SDCContext(dbContextOptions);
        //    _controller = new InvoicesController(_context);
        //    var invoice = new Invoice()
        //    {
        //        ProjectId = 1,
        //        InvoiceDate = DateTime.Now,
        //        BillPlace = "Conestoga",
        //        BillAddress = "Waterloo",
        //        ShipPlace = "Studio Design Collection",
        //        ShipAddress = "Cambridge"
        //    };

        //    //Act
        //    var result = await _controller.PostInvoice(invoice);

        //    //Assert
        //    var okResult = result.Should().BeOfType<CreatedAtActionResult>().Subject;
        //    var resInvoice = okResult.Value.Should().BeAssignableTo<Invoice>().Subject;
        //    resInvoice.BillPlace.Should().Be("Conestoga");

        //    //delete JayNew
        //    int newId = _context.Invoice.FirstOrDefault(p => p.BillPlace == "Conestoga").ProjectId;
        //    var resultDelete = await _controller.DeleteInvoice(newId);
        //}

        //[Fact]
        //public async void Task4_Put_Update_Invoice_NoContentResult()
        //{
        //    //Arrange
        //    _context = new SDCContext(dbContextOptions);
        //    _controller = new InvoicesController(_context);
        //    int newId = 1;

        //    //Act
        //    var updateData = new Invoice()
        //    {
        //        ProjectId = newId,
        //        InvoiceDate = DateTime.Now,
        //        BillPlace = "Pickle",
        //        BillAddress = "Kitchener",
        //        ShipPlace = "Studio Design Collection",
        //        ShipAddress = "Cambridge"

        //    };
        //    var updatedData = await _controller.PutInvoice(newId, updateData);

        //    //Assert
        //    Assert.IsType<NoContentResult>(updatedData);
        //}

        //[Fact]
        //private async void Task5_Delete_Invoice_OkResult()
        //{
        //    //Arrange
        //    _context = new SDCContext(dbContextOptions);
        //    _controller = new InvoicesController(_context);
        //    var invoice = new Invoice()
        //    {
        //        ProjectId = 5,
        //        InvoiceDate = DateTime.Now,
        //        BillPlace = "NewPicker",
        //        BillAddress = "Kitchener",
        //        ShipPlace = "Studio Design Collection",
        //        ShipAddress = "Cambridge"

        //    };

        //    //Act
        //    var resultCreate = await _controller.PostInvoice(invoice);
        //    var okResult = resultCreate.Should().BeOfType<CreatedAtActionResult>().Subject;
        //    var resInvoice = okResult.Value.Should().BeAssignableTo<Invoice>().Subject;
        //    int delId = resInvoice.ProjectId;
        //    var result = await _controller.DeleteInvoice(delId);

        //    //Assert
        //    Assert.IsType<OkObjectResult>(result);
        //}
    }
}
