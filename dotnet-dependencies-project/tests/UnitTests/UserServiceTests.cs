using System;
using System.Threading.Tasks;
using Xunit;
using Moq;
using dotnet_dependencies_project.Services;
using dotnet_dependencies_project.Models;

namespace dotnet_dependencies_project.tests.UnitTests
{
    public class UserServiceTests
    {
        private readonly Mock<IUserService> _userServiceMock;
        private readonly UserService _userService;

        public UserServiceTests()
        {
            _userServiceMock = new Mock<IUserService>();
            _userService = new UserService(/* dependencies */);
        }

        [Fact]
        public async Task CreateUser_ShouldReturnUser_WhenUserIsValid()
        {
            // Arrange
            var user = new User { Id = 1, Name = "Test User", Email = "test@example.com" };
            _userServiceMock.Setup(service => service.CreateUser(user)).ReturnsAsync(user);

            // Act
            var result = await _userService.CreateUser(user);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(user.Name, result.Name);
        }

        [Fact]
        public async Task GetUser_ShouldReturnUser_WhenUserExists()
        {
            // Arrange
            var userId = 1;
            var user = new User { Id = userId, Name = "Test User", Email = "test@example.com" };
            _userServiceMock.Setup(service => service.GetUser(userId)).ReturnsAsync(user);

            // Act
            var result = await _userService.GetUser(userId);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(userId, result.Id);
        }

        [Fact]
        public async Task DeleteUser_ShouldReturnTrue_WhenUserIsDeleted()
        {
            // Arrange
            var userId = 1;
            _userServiceMock.Setup(service => service.DeleteUser(userId)).ReturnsAsync(true);

            // Act
            var result = await _userService.DeleteUser(userId);

            // Assert
            Assert.True(result);
        }
    }
}