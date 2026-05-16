namespace _6._2_Dars.Entities;

public class Student
{

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Group { get; set; }


    public ICollection<Student> Students { get; set; }

    public ICollection<Teacher> Teachers { get; set; }


}