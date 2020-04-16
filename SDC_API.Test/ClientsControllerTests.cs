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
    public class ClientsControllerTests
    {
        private static DbContextOptions<SDCContext> dbContextOptions { get; }
        private static string connectionString = "Server=localhost;Database=SDC;Trusted_Connection=True;MultipleActiveResultSets=true";
        private SDCContext _context;
        private ClientsController _controller;

        static ClientsControllerTests()
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
            _controller = new ClientsController(_context);

            //Act
            var result = await _controller.GetClient(Id);

            //Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async void Task2_GetById_Return_NotFoundResult()
        {
            //Arrange
            var Id = 222;
            _context = new SDCContext(dbContextOptions);
            _controller = new ClientsController(_context);

            //Act
            var result = await _controller.GetClient(Id);

            //Assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async void Task3_Post_NewClient_FindName()
        {
            //Arrange
            _context = new SDCContext(dbContextOptions);
            _controller = new ClientsController(_context);
            var client = new Client()
            {
                FirstName = "New_Pickle",
                LastName = "Jang",
                Category = "DD",
                Company = "Ms",
                Phone = "5192418094",
                Address = "60 Wentworth Ave",
                City = null,
                Province = null,
                Postalcode = null,
                Email = "jay@gmail.com",
                Website = "https://conestogac.on.ca/",
                BizType = "Interior Consultant",
                BizYear = "1998 - 22 years",
                Associations = "DDA",
                Recommender = "Supplier",
                Hst = "855448298",
                Reference = "Kravet, Cocoon, Marks Supply, JF Fabrics, Maxwell fabrics",
                Mailing = "Y",
                Term = "0.5",
                Timestamp = DateTime.Now,
                Comments = null
            };

            //Act
            var result = await _controller.PostClient(client);

            //Assert
            var okResult = result.Should().BeOfType<CreatedAtActionResult>().Subject;
            var resClient = okResult.Value.Should().BeAssignableTo<Client>().Subject;
            resClient.FirstName.Should().Be("New_Pickle");

            //delete JayNew
            int newId = _context.Client.FirstOrDefault(p => p.FirstName == "New_Pickle").ClientId;
            var resultDelete = await _controller.DeleteClient(newId);
        }

        [Fact]
        public async void Task4_Put_UpdateClient_NoContentResult()
        {
            //Arrange
            _context = new SDCContext(dbContextOptions);
            _controller = new ClientsController(_context);
            int newId = 109;

            //Act
            var updateData = new Client()
            {
                ClientId = newId,
                FirstName = "Update_Pickle",
                LastName = "Jang",
                Category = "DD",
                Company = "Ms",
                Phone = "5192418094",
                Address = "60 Wentworth Ave",
                City = null,
                Province = null,
                Postalcode = null,
                Email = "jay@gmail.com",
                Website = "https://conestogac.on.ca/",
                BizType = "Interior Consultant",
                BizYear = "1998 - 22 years",
                Associations = "DDA",
                Recommender = "Supplier",
                Hst = "855448298",
                Reference = "Kravet, Cocoon, Marks Supply, JF Fabrics, Maxwell fabrics",
                Mailing = "Y",
                Term = "0.5",
                Timestamp = DateTime.Now,
                Comments = null
            };
            var updatedData = await _controller.PutClient(newId, updateData);

            //Assert
            Assert.IsType<NoContentResult>(updatedData);
        }

        [Fact]
        private async void Task5_Delete_Client_OkResult()
        {
            //Arrange
            _context = new SDCContext(dbContextOptions);
            _controller = new ClientsController(_context);
            var client = new Client()
            {
                FirstName = "JayDel",
                LastName = "Jang",
                Category = "DD",
                Company = "Ms",
                Phone = "5192418094",
                Address = "60 Wentworth Ave",
                City = null,
                Province = null,
                Postalcode = null,
                Email = "jay@gmail.com",
                Website = "https://conestogac.on.ca/",
                BizType = "Interior Consultant",
                BizYear = "1998 - 22 years",
                Associations = "DDA",
                Recommender = "Supplier",
                Hst = "855448298",
                Reference = "Kravet, Cocoon, Marks Supply, JF Fabrics, Maxwell fabrics",
                Mailing = "Y",
                Term = "0.5",
                Timestamp = DateTime.Now,
                Comments = null
            };

            //Act
            var resultCreate = await _controller.PostClient(client);
            var okResult = resultCreate.Should().BeOfType<CreatedAtActionResult>().Subject;
            var resClient = okResult.Value.Should().BeAssignableTo<Client>().Subject;
            int delId = resClient.ClientId;            
            var result = await _controller.DeleteClient(delId);

            //Assert
            Assert.IsType<OkObjectResult>(result);
        }

    }
}
