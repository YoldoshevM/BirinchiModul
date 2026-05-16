using _6._2_Dars.Data;
using _6._2_Dars.Dtos;
using _6._2_Dars.Entities;
using Microsoft.EntityFrameworkCore;

namespace _6._2_Dars.Services;

public class TeacherService : ITeacherService
{

    private readonly AppDbContext _context;

    public TeacherService(AppDbContext context)
    {
        _context = context;
    }



    public async Task<int> AddAsync(TeacherCreateDto teacherCreateDto)
    {

        var teacher = new Teacher()
        {
            FirstName = teacherCreateDto.FirstName,
            LastName = teacherCreateDto.LastName,
            Subject = teacherCreateDto.Subject,
            ExperienceYears = teacherCreateDto.ExperienceYears
        };

        await _context.Teachers.AddAsync(teacher);

        await _context.SaveChangesAsync();

        return teacher.Id;

    }

    public async Task<bool> DeleteAsync(int id)
    {

        var teacher = await _context.Teachers
    .FirstOrDefaultAsync(x => x.Id == id);

        if (teacher == null)
        {
            return false;
        }

        _context.Teachers.Remove(teacher);

        await _context.SaveChangesAsync();

        return true;



    }

    public async Task<List<TeacherGetDto>> GetAllAsync()
    {

        var teachers = await _context.Teachers.ToListAsync();

        return teachers.Select(t => new TeacherGetDto()
        {
            Id = t.Id,
            FirstName = t.FirstName,
            LastName = t.LastName,
            Subject = t.Subject,
            ExperienceYears = t.ExperienceYears
        }).ToList();


    }
}
