using _5._8_Dars.Dtos;
using _5._8_Dars.Entities;
using _5._8_Dars.Repositories;

namespace _5._8_Dars.Service;

public class TeacherService
{

    private readonly TeacherRepository _repo;

    public TeacherService(TeacherRepository repo)
    {
        _repo = repo;
    }

    public List<Teacher> GetAll()
    {
        return _repo.GetAll();
    }

    public void Create(TeacherDto dto)
    {
        _repo.Create(dto);
    }



}
