using User.Server.Entities;

namespace User.Server.Entities;



    
public class AppDBContext
{

    public static List<User> Users { get; set; }
    public static List<Post> Posts { get; set; }
    


    static AppDBContext()
    {
        Users = new List<User>();
        Posts = new List<Post>();
    }


}
