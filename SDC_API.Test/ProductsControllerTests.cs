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
    public class ProductsControllerTests
    {
        private static DbContextOptions<SDCContext> dbContextOptions { get; }
        private static string connectionString = "Server = 34.73.191.28; Database=SDC;Uid=sqlserver;Password=Conestoga20";
        private SDCContext _context;
        private ProductsController _controller;

        static ProductsControllerTests()
        {
            dbContextOptions = new DbContextOptionsBuilder<SDCContext>()
                .UseSqlServer(connectionString)
                .Options;
        }

        [Fact]
        public async void Task1_GetById_Return_OkResult()
        {
            //Arrange
            var productId = "28B1PO";
            var supplierId = 1;
            _context = new SDCContext(dbContextOptions);
            _controller = new ProductsController(_context);

            //Act
            var result = await _controller.GetProduct(productId, supplierId);

            //Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async void Task2_GetById_Return_NotFoundResult()
        {
            //Arrange
            var productId = "28B1PO";
            var supplierId = 2;
            _context = new SDCContext(dbContextOptions);
            _controller = new ProductsController(_context);

            //Act
            var result = await _controller.GetProduct(productId, supplierId);

            //Assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async void Task3_Post_New_Product_FindName()
        {
            //Arrange
            _context = new SDCContext(dbContextOptions);
            _controller = new ProductsController(_context);
            var product = new Product()
            {
                SupplierId = 1,
                ProductId = "NewPKItem"
            };

            //Act
            var result = await _controller.PostProduct(product);

            //Assert
            var okResult = result.Should().BeOfType<CreatedAtActionResult>().Subject;
            var resProduct = okResult.Value.Should().BeAssignableTo<Product>().Subject;
            resProduct.ProductId.Should().Be("NewPKItem");

            //delete JayNew
            int SupplierId = _context.Product.FirstOrDefault(p => p.ProductId == "NewPKItem").SupplierId;
            string ProductId = _context.Product.FirstOrDefault(p => p.ProductId == "NewPKItem").ProductId;
            var resultDelete = await _controller.DeleteProduct(ProductId, SupplierId);
        }

        [Fact]
        public async void Task4_Put_Update_Product_NoContentResult()
        {
            //Arrange
            _context = new SDCContext(dbContextOptions);
            _controller = new ProductsController(_context);
            var productId = "NewPItem";
            var supplierId = 1;

            //Act
            var product = new Product()
            {
                SupplierId = 1,
                ProductId = "NewPItem",
                Dimension = "Length 2m"

            };
            var updatedData = await _controller.PutProduct(productId, supplierId, product);

            //Assert
            Assert.IsType<NoContentResult>(updatedData);
        }

        [Fact]
        private async void Task5_Delete_product_OkResult()
        {
            //Arrange
            _context = new SDCContext(dbContextOptions);
            _controller = new ProductsController(_context);
            var product = new Product()
            {
                SupplierId = 1,
                ProductId = "DelPkItem"
            };

            //Act
            var resultCreate = await _controller.PostProduct(product);
            var okResult = resultCreate.Should().BeOfType<CreatedAtActionResult>().Subject;
            var resProduct = okResult.Value.Should().BeAssignableTo<Product>().Subject;
            string delProductId = resProduct.ProductId;
            int delSupplierId = resProduct.SupplierId;

            var result = await _controller.DeleteProduct(delProductId, delSupplierId);

            //Assert
            Assert.IsType<OkObjectResult>(result);
        }
    }
}
