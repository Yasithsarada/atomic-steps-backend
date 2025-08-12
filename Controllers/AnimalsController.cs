using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AtomicSteps.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllAnimals()
        {
            string[] students = new string[] { "Alice", "Bob", "Charlie", "Diana" };
            return Ok(students);

        }
    }
}
