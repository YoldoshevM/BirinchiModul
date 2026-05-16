using System.Data;
using System.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

string connectionString = "Server=localhost;Database=AdoNet;User Id=sa;Password=1234;";

// GET all teachers
app.MapGet("/api/teachers", () =>
{
    var list = new List<object>();

    using (SqlConnection conn = new SqlConnection(connectionString))
    {
        SqlCommand cmd = new SqlCommand("sp_GetTeachers", conn);
        cmd.CommandType = CommandType.StoredProcedure;

        conn.Open();
        var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            list.Add(new
            {
                TeacherId = reader["TeacherId"],
                FirstName = reader["FirstName"],
                LastName = reader["LastName"],
                Subject = reader["Subject"]
            });
        }
    }

    return Results.Ok(list);
});

// CREATE teacher
app.MapPost("/api/teachers", (TeacherDto dto) =>
{
    using (SqlConnection conn = new SqlConnection(connectionString))
    {
        SqlCommand cmd = new SqlCommand("sp_CreateTeacher", conn);
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@FirstName", dto.FirstName);
        cmd.Parameters.AddWithValue("@LastName", dto.LastName);
        cmd.Parameters.AddWithValue("@Subject", dto.Subject);

        conn.Open();
        cmd.ExecuteNonQuery();
    }

    return Results.Ok("Created");
});
