using _5._8_Dars.Dtos;
using _5._8_Dars.Service;
using Microsoft.AspNetCore.Mvc;

namespace _5._8_Dars.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly TeacherService _service;

        public TeachersController(TeacherService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetAll());
        }

        [HttpPost]
        public IActionResult Create(TeacherDto dto)
        {
            _service.Create(dto);
            return Ok();
        }
    }
}
