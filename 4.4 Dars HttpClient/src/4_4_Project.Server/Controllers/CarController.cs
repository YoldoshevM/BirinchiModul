using _4_4_Project.Server.Entities;
using _4_4_Project.Server.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _4_4_Project.Server.Controllers
{
    [Route("car/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _service;

        public CarController(ICarService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Add(Car car)
        {
            _service.Add(car);
            return Ok(car);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var car = _service.GetById(id);
            if (car == null) return NotFound();
            return Ok(car);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _service.Delete(id);
            return Ok();
        }
    }
}
