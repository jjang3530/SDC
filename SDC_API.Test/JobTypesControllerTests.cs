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
    public class JobTypesControllerTests
    {
        private static DbContextOptions<SDCContext> dbContextOptions { get; }
        private static string connectionString = "Server = 34.73.191.28; Database=SDC;Uid=sqlserver;Password=Conestoga20";
        private SDCContext _context;
        private JobTypesController _controller;

        static JobTypesControllerTests()
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
            _controller = new JobTypesController(_context);

            //Act
            var result = await _controller.GetJobType(Id);

            //Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async void Task2_GetById_Return_NotFoundResult()
        {
            //Arrange
            var Id = 32;
            _context = new SDCContext(dbContextOptions);
            _controller = new JobTypesController(_context);

            //Act
            var result = await _controller.GetJobType(Id);

            //Assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async void Task3_Post_NewJobType_JobTitle()
        {
            //Arrange
            _context = new SDCContext(dbContextOptions);
            _controller = new JobTypesController(_context);
            var jobType = new JobType()
            {
                JobTitle = "Mechanic",
            };

            //Act
            var result = await _controller.PostJobType(jobType);

            //Assert
            var okResult = result.Should().BeOfType<CreatedAtActionResult>().Subject;
            var resClient = okResult.Value.Should().BeAssignableTo<JobType>().Subject;
            resClient.JobTitle.Should().Be("Mechanic");

            //delete JayNew
            int newId = _context.JobType.FirstOrDefault(p => p.JobTitle == "Mechanic").JobId;
            var resultDelete = await _controller.DeleteJobType(newId);
        }

        [Fact]
        public async void Task4_Put_Update_JobType_NoContentResult()
        {
            //Arrange
            _context = new SDCContext(dbContextOptions);
            _controller = new JobTypesController(_context);
            int newId = 4;

            //Act
            var jobType = new JobType()
            {
                JobId = newId,
                JobTitle = "Graduated"
            };
            var updatedData = await _controller.PutJobType(newId, jobType);

            //Assert
            Assert.IsType<NoContentResult>(updatedData);
        }

        [Fact]
        private async void Task5_Delete_JobType_OkResult()
        {
            //Arrange
            _context = new SDCContext(dbContextOptions);
            _controller = new JobTypesController(_context);
            var jobType = new JobType()
            {
                JobTitle = "New and Del title",
            };

            //Act
            var resultCreate = await _controller.PostJobType(jobType);
            var okResult = resultCreate.Should().BeOfType<CreatedAtActionResult>().Subject;
            var resClient = okResult.Value.Should().BeAssignableTo<JobType>().Subject;
            int delId = resClient.JobId;
            var result = await _controller.DeleteJobType(delId);

            //Assert
            Assert.IsType<OkObjectResult>(result);
        }
    }
}
