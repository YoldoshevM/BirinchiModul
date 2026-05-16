namespace _6._2_Dars.Entities;

public class Teacher
{

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Subject { get; set; }
    public int ExperienceYears { get; set; }



    public ICollection<Teacher> Teachers { get; set; }

    public ICollection<Student> Students { get; set; }


}
