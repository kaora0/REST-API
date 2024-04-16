using Microsoft.AspNetCore.Mvc;

namespace Lab_31.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestikController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index(string str)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Add(int age, string Name)
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult Update()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete() 
        {
            return Ok();
        }
    }
}
