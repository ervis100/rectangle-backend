using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RectangleBackend.DTO;
using RectangleBackend.Service;

namespace RectangleBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RectController : ControllerBase
    {

        private IRectService rectService;

        public RectController(IRectService rectService) 
        {
            this.rectService = rectService;
        }

        [HttpGet("/hello")]
        public IActionResult Get()
        {
            return Ok(rectService.sayHello());
        }

        [HttpGet("/meassurements")]
        public IActionResult GetMeassurements()
        {
            return Ok(rectService.getMeassurements());
        }

        [HttpPost("/meassurements")]
        public IActionResult UpdateMeasurements([FromBody] Meassurement measurement)
        {
            return Ok(rectService.updateMeasurements(measurement));
        }

    }
}
