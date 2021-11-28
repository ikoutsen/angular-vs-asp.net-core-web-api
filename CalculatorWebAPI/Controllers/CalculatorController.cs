using CalculatorWebAPI.Analizers;
using CalculatorWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CalculatorWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class CalculatorController : Controller
    {
        private IDistaceAnalizer analizer;
        public CalculatorController(IDistaceAnalizer analizer)
        {
            this.analizer = analizer;
        }
        [HttpPost]
        public ActionResult Post([FromBody] Point[] points)
        {
            if (points != null && points.Length == 2)
                return Ok(analizer.GetDistace(points[0], points[1]));
            return BadRequest();
        }
    }
}
