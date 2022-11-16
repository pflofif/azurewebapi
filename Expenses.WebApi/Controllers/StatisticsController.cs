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

        [HttpGet("Data")]
        public IActionResult GetData()
        {
            return Ok(
                new[]
                {
                    new { data = "data"},
                    new { data = "da21dfsdfta"},
                    new { data = "ds12dfata"},
                    new { data = "ds1dfata"},
                    new { data = "ds1212aasdata"},
                    new { data = "d121212ata"},
                });
        }
    }
}
