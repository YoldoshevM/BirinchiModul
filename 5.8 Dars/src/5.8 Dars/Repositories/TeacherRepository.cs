using _5._8_Dars.Entities;
using System.Data;
using System.Data.SqlClient;



namespace _5._8_Dars.Repositories;

public class TeacherRepository
{



    private readonly string _connection;

    public TeacherRepository(IConfiguration config)
    {
        _connection = config.GetConnectionString("DefaultConnection");
    }

    public List<Teacher> GetAll()
    {
        var list = new List<Teacher>();

        using (SqlConnection conn = new SqlConnection(_connection))
        {
            SqlCommand cmd = new SqlCommand("sp_GetTeachers", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            conn.Open();
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Teacher
                {
                    TeacherId = (int)reader["TeacherId"],
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    Subject = reader["Subject"].ToString()
                });
            }
        }

        return list;
    }

    public void Create(TeacherDto dto)
    {
        using (SqlConnection conn = new SqlConnection(_connection))
        {
            SqlCommand cmd = new SqlCommand("sp_CreateTeacher", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@FirstName", dto.FirstName);
            cmd.Parameters.AddWithValue("@LastName", dto.LastName);
            cmd.Parameters.AddWithValue("@Subject", dto.Subject);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }





}
