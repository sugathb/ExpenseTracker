using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExpensesController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello..");
        }
    }
}
