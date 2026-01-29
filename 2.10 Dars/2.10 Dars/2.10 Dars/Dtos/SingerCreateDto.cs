using System;
using System.Collections.Generic;
using System.Text;

namespace _2._10_Dars.Dtos;

public class SingerCreateDto
{

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string SingerName { get; set; }
    public string Password { get; set; }
    public List<string> MusicNames { get; set; }
    public List<string> Genres { get; set; }
    public List<string> Awards { get; set; }


}
