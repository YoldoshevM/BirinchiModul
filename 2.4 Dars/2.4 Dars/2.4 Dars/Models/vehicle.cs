using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _2._4_Dars.Models;

internal class vehicle : Transport
{

    public string Varient { get; set; }


    public vehicle(string varient)
    {
        Varient = varient;
        Console.WriteLine("vhicle ctor ishladi");
    }

    public vehicle()
    {
        
    }


}
