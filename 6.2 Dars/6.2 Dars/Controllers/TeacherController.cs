using _6._2_Dars.Dtos;
using _6._2_Dars.Services;
using Microsoft.AspNetCore.Mvc;

namespace _6._2_Dars.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TeacherController : ControllerBase
{
    private readonly ITeacherService _teacherService;

    public TeacherController(ITeacherService teacherService)
    {
        _teacherService = teacherService;
    }

    [HttpPost]
    public async Task<IActionResult> AddAsync(TeacherCreateDto teacherCreateDto)
    {
        var result = await _teacherService.AddAsync(teacherCreateDto);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var result = await _teacherService.GetAllAsync();

        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        var result = await _teacherService.DeleteAsync(id);

        if (result == false)
        {
            return NotFound("Teacher topilmadi");
        }

        return Ok("Teacher deleted");
    }
}