using MediaMaker.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace MediaMaker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculationController : ControllerBase
    {
        [HttpPost("add")]
        public IActionResult Add(Calculation calculation)
        {
            calculation.Result = calculation.Number1 + calculation.Number2;
            var response = JsonSerializer.Serialize(calculation.Result);
            return Ok(response);
        }

        [HttpPost("subtract")]
        public IActionResult Sub(Calculation calculation)
        {
            calculation.Result = calculation.Number1 - calculation.Number2;
            var response = JsonSerializer.Serialize(calculation.Result);
            return Ok(response);
        }

        [HttpPost("multipy")]
        public IActionResult Mul(Calculation calculation)
        {
            calculation.Result = calculation.Number1 * calculation.Number2;
            var response = JsonSerializer.Serialize(calculation.Result);
            return Ok(response);
        }

        [HttpPost("division")]
        public IActionResult Div(Calculation calculation)
        {
            try
            {
                calculation.Result = calculation.Number1 / calculation.Number2;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            var response = JsonSerializer.Serialize(calculation.Result);
            return Ok(response);
        }

    }
}
