using System;
using System.Collections.Generic;
using System.Text;

namespace _2._4_Dars.Models;

public class Transport
{

    public Guid TransportId { get; set; }
    public string Color { get; set; }
    public double Speed { get; set; }
    public double Weight { get; set; }
    public double Height { get; set; }

    public Transport()
    {
        Console.WriteLine(" Transport ctro ishladi ");
    }

}
