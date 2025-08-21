using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers
{
    [Route(template: "api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet(template: "sum")]
        public IActionResult GetSum([FromQuery] int a, [FromQuery] int b)
        {
             int result = a + b;
            return Ok(new { a, b, result });
        }
        [HttpGet(template: "Resta")]
        public IActionResult Getresta([FromQuery] int a, [FromQuery] int b)
        {
            int result = a - b;
            return Ok(new { a, b, result });
        }
        [HttpGet(template: "Multiplicacion")]
        public IActionResult GetMultiplicacion([FromQuery] int a, [FromQuery] int b)
        {
            int result = a * b;
            return Ok(new { a, b, result });
        }
        [HttpGet(template: "division")]
        public IActionResult Getdivision([FromQuery] int a, [FromQuery] int b)
        {
            if (b == 0)
                {
                    return BadRequest();
                }
            int result = a/b;
            return Ok(new { a, b, result });
        }
    }
}