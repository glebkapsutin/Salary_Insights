using Microsoft.AspNetCore.Mvc;
using Moq;
using server.Application.Interfaces;
using server.Presentation.Controllers;
using server.Core.Models;
using Xunit;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace Salary_Insights.Tests
{
    public class UserControllerTests
    {
        private readonly Mock<IUserService> _userServiceMock;

        private readonly UserController _controller;
        public UserControllerTests()
        {
            _userServiceMock = new Mock<IUserService>();
            _controller = new UserController(_userServiceMock.Object);
        }
        [Fact]
        public async Task GetUsers_ReturnsOkWithUsers()
        {
            var users = new List<User>
            {
                new User { Id = 1,Username="user1", Email = "user1@example.com", Role="User" },
                new User { Id = 2, Username = "user2", Email = "user2@example.com", Role = "Admin" }
            };
            _userServiceMock.Setup(s=> s.GetUsersAsync()).ReturnsAsync(users);

            var result = await _controller.GetUsers();
            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var returnUsers = Assert.IsAssignableFrom<IEnumerable<User>>(okResult.Value);
            Assert.Equal(2, returnUsers.Count());
            Assert.Contains(returnUsers, u => u.Username == "user1");
        }

        [Fact]
        public async Task GetUserId_UnauthorizedUser_ReturnsUnauthorized()
        {
            // Arrange
            _controller.ControllerContext = new ControllerContext
            {
                HttpContext = new DefaultHttpContext()
            };

            // Act
            var result = await _controller.GetUserId(1);

            // Assert
            var unauthorizedResult = Assert.IsType<UnauthorizedObjectResult>(result.Result);
            Assert.Equal("Пользователь не авторизован", unauthorizedResult.Value.GetType().GetProperty("message").GetValue(unauthorizedResult.Value));
        }
        [Fact]
        public async Task GetUserId_ValidId_ReturnsOk()
        {
            // Arrange
            var user = new User { Id = 1, Username = "user1", Email = "user1@example.com", Role = "User" };
            _userServiceMock.Setup(s => s.GetUserByIdAsync(1)).ReturnsAsync(user);
            var claims = new List<Claim> { new Claim(ClaimTypes.NameIdentifier, "1") };
            var identity = new ClaimsIdentity(claims, "TestAuth");
            var principal = new ClaimsPrincipal(identity);
            _controller.ControllerContext = new ControllerContext
            {
                HttpContext = new DefaultHttpContext { User = principal }
            };

            // Act
            var result = await _controller.GetUserId(1);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var returnUser = Assert.IsType<User>(okResult.Value);
            Assert.Equal(1, returnUser.Id);
            Assert.Equal("user1", returnUser.Username);
        }
    }
}
