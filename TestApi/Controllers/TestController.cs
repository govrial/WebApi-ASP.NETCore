using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : Controller
    {

        private static List<TestClass> test = new List<TestClass>
            {
                new TestClass {
                    Id = 1,
                    Name = "Spider-man",
                    FirstName = "Peter",
                    LastName = "Parker",
                    Place = "New-York"
                }
            };

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(test);
        }
    }
}
