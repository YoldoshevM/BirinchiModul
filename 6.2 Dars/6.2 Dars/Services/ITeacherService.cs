using _6._2_Dars.Dtos;

namespace _6._2_Dars.Services;

public interface ITeacherService
{

    Task<int> AddAsync(TeacherCreateDto teacherCreateDto);

    Task<List<TeacherGetDto>> GetAllAsync();

    Task<bool> DeleteAsync(int id);


}