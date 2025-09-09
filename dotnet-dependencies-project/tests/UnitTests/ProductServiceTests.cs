using System;
using System.Threading.Tasks;
using Xunit;
using Moq;
using dotnet_dependencies_project.Services;
using dotnet_dependencies_project.Models;

namespace dotnet_dependencies_project.tests.UnitTests
{
    public class ProductServiceTests
    {
        private readonly Mock<IProductService> _mockProductService;
        private readonly ProductService _productService;

        public ProductServiceTests()
        {
            _mockProductService = new Mock<IProductService>();
            _productService = new ProductService(_mockProductService.Object);
        }

        [Fact]
        public async Task CreateProduct_ShouldReturnProduct_WhenProductIsValid()
        {
            // Arrange
            var product = new Product { Id = 1, Name = "Test Product", Price = 10.0m };
            _mockProductService.Setup(service => service.CreateProduct(product)).ReturnsAsync(product);

            // Act
            var result = await _productService.CreateProduct(product);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(product.Name, result.Name);
        }

        [Fact]
        public async Task GetProduct_ShouldReturnProduct_WhenProductExists()
        {
            // Arrange
            var productId = 1;
            var product = new Product { Id = productId, Name = "Test Product", Price = 10.0m };
            _mockProductService.Setup(service => service.GetProduct(productId)).ReturnsAsync(product);

            // Act
            var result = await _productService.GetProduct(productId);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(productId, result.Id);
        }

        [Fact]
        public async Task DeleteProduct_ShouldReturnTrue_WhenProductIsDeleted()
        {
            // Arrange
            var productId = 1;
            _mockProductService.Setup(service => service.DeleteProduct(productId)).ReturnsAsync(true);

            // Act
            var result = await _productService.DeleteProduct(productId);

            // Assert
            Assert.True(result);
        }
    }
}