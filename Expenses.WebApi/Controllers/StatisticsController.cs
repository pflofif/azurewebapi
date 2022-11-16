using Expenses.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Expenses.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StatisticsController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetExpenseAmountPerCategory()
        {
            return Ok(new[]
            {
                new{ name = "ddd"},
                new{ name = "ff"},
                new{ name = "fdf"},
                new{ name = "dhdod"},
                new{ name = "dhjhjdd"},
            });
        }
    }
}
