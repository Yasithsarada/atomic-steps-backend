using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AtomicSteps.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetAllStudents()
        {
            string[] students = new string[] { "Alice", "Bob", "Charlie", "Diana" };
            return Ok(students);
        }
    }
}
