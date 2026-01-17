using System;
using System.Collections.Generic;
using System.Text;

namespace _2._5_Dars.Models;

public class Singer
{

    public Guid SingerId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int NumberOfMusics { get; set; }
    public string Country { get; set; }

}
