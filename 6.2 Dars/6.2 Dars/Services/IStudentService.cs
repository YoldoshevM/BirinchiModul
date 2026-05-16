using _6._2_Dars.Dtos;
using _6._2_Dars.Entities;

namespace _6._2_Dars.Services;

public interface IStudentService
{

    Task<int> AddAsync(StudentCreateDto studentCreateDto);

    Task<List<StudentGetDto>> GetAllAsync();

    Task<bool> DeleteAsync(long id);


}