using System;
using System.Collections.Generic;
using System.Text;

namespace _2._4_Dars.Models;

internal class Vhicle : Transport
{

    public string Varienty { get; set; }


    public Vhicle(string varienty)
    {

        Varienty = varienty;
        Console.WriteLine("Vhicle ctro ishladi");

    }



}
