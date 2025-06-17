using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
        [HttpGet]
         async Task<List<string>> Todos()
        {
            var todos = new List<string> { "Learn DevOps", "Build CI/CD","؛Publish to github" };
            return todos;
        }

        [HttpGet]
        public async Task<IActionResult> GetTodos()
        {
            return   Ok(await Todos());
        }  
    }
}
