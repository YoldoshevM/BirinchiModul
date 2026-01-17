using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _2._4_Dars.Models;

public class Car : Vhicle
{

    public Car(string varienty)
    {

        Varienty = varienty;
        Console.WriteLine("Car ctor ishladi ");

    }

}
