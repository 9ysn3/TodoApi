using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApi.Controllers;

namespace TodoApi.Tests
{
    public class TodoControllerTests
    {
        [Fact]
        public async Task GetTodos_ReturnsOkResult_WithTodoList()
        {
            // Arrange
            var controller = new TodoController();

            // Act
            var result =await controller.GetTodos();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var todos = Assert.IsType<List<string>>(okResult.Value);
            Assert.Equal(3, todos.Count); // لأن عندنا "Learn DevOps" و "Build CI/CD"
            Assert.Contains("Learn DevOps", todos);
            Assert.Contains("Build CI/CD", todos);
        }
    }
}
