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
    public class EmployeesControllerTests
    {
        private static DbContextOptions<SDCContext> dbContextOptions { get; }
        private static string connectionString = "Server=localhost;Database=SDC;Trusted_Connection=True;MultipleActiveResultSets=true";
        private SDCContext _context;
        private EmployeesController _controller;

        static EmployeesControllerTests()
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
            _controller = new EmployeesController(_context);

            //Act
            var result = await _controller.GetEmployee(Id);

            //Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async void Task2_GetById_Return_NotFoundResult()
        {
            //Arrange
            var Id = 32;
            _context = new SDCContext(dbContextOptions);
            _controller = new EmployeesController(_context);

            //Act
            var result = await _controller.GetEmployee(Id);

            //Assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async void Task3_Post_NewEmployee_FindName()
        {
            //Arrange
            _context = new SDCContext(dbContextOptions);
            _controller = new EmployeesController(_context);
            var employee = new Employee()
            {
                UserName = "Toronto",
                FirstName = "Pascal",
                LastName = "Siakam",
                Password = "a1234b",
                JobId = 3
            };

            //Act
            var result = await _controller.PostEmployee(employee);

            //Assert
            var okResult = result.Should().BeOfType<CreatedAtActionResult>().Subject;
            var resClient = okResult.Value.Should().BeAssignableTo<Employee>().Subject;
            resClient.FirstName.Should().Be("Pascal");

            //delete JayNew
            int newId = _context.Employee.FirstOrDefault(p => p.FirstName == "Pascal").UserId;
            var resultDelete = await _controller.DeleteEmployee(newId);
        }

        [Fact]
        public async void Task4_Put_Update_Employee_NoContentResult()
        {
            //Arrange
            _context = new SDCContext(dbContextOptions);
            _controller = new EmployeesController(_context);
            int newId = 7;

            //Act
            var employee = new Employee()
            {
                UserId = newId,
                UserName = "NewKyrie",
                FirstName = "Jay",
                LastName = "Jang",
                Password = "a1234bcdef",
                JobId = 3
            };
            var updatedData = await _controller.PutEmployee(newId, employee);

            //Assert
            Assert.IsType<NoContentResult>(updatedData);
        }

        [Fact]
        private async void Task5_Delete_Employee_OkResult()
        {
            //Arrange
            _context = new SDCContext(dbContextOptions);
            _controller = new EmployeesController(_context);
            var employee = new Employee()
            {
                UserName = "CDKyrie",
                FirstName = "Kevin",
                LastName = "Durant",
                Password = "a1234b",
                JobId = 3
            };

            //Act
            var resultCreate = await _controller.PostEmployee(employee);
            var okResult = resultCreate.Should().BeOfType<CreatedAtActionResult>().Subject;
            var resClient = okResult.Value.Should().BeAssignableTo<Employee>().Subject;
            int delId = resClient.UserId;
            var result = await _controller.DeleteEmployee(delId);

            //Assert
            Assert.IsType<OkObjectResult>(result);
        }
    }
}

