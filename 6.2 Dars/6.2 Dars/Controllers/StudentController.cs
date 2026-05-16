using _6._2_Dars.Dtos;
using _6._2_Dars.Services;
using Microsoft.AspNetCore.Mvc;

namespace _6._2_Dars.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentController : ControllerBase
{
    private readonly IStudentService _studentService;

    public StudentController(IStudentService studentService)
    {
        _studentService = studentService;
    }

    [HttpPost]
    public async Task<IActionResult> AddAsync(StudentCreateDto studentCreateDto)
    {
        var result = await _studentService.AddAsync(studentCreateDto);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var result = await _studentService.GetAllAsync();

        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        var result = await _studentService.DeleteAsync(id);

        if (result == false)
        {
            return NotFound("Student topilmadi");
        }

        return Ok("Student deleted");
    }
}