using _6._2_Dars.Data;
using _6._2_Dars.Dtos;
using _6._2_Dars.Entities;
using Microsoft.EntityFrameworkCore;

namespace _6._2_Dars.Services;

public class StudentService : IStudentService
{

    private readonly AppDbContext _context;

    public StudentService(AppDbContext context)
    {
        _context = context;
    }



    public async Task<int> AddAsync(StudentCreateDto studentCreateDto)
    {


        var student = new Student()
        {
            FirstName = studentCreateDto.FirstName,
            LastName = studentCreateDto.LastName,
            Age = studentCreateDto.Age,
            Group = studentCreateDto.Group
        };

        await _context.Students.AddAsync(student);
        await _context.SaveChangesAsync();

        return student.Id;

    }

    public async Task<bool> DeleteAsync(long id)
    {

        var student = await _context.Students
    .FirstOrDefaultAsync(x => x.Id == id);

        if (student == null)
        {
            return false;
        }

        _context.Students.Remove(student);

        await _context.SaveChangesAsync();

        return true;

    }

    public async Task<List<StudentGetDto>> GetAllAsync()
    {

        var students = await _context.Students.ToListAsync();

        return students.Select(s => new StudentGetDto()
        {
            Id = s.Id,
            FirstName = s.FirstName,
            LastName = s.LastName,
            Age = s.Age,
            Group = s.Group
        }).ToList();
    }
}
