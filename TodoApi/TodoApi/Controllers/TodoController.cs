using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
        private static readonly List<string> Todos = new() { "Learn DevOps", "Build CI/CD" };

        [HttpGet]
        public async Task<IActionResult> GetTodos() =>  Ok(Todos);
    }
}
