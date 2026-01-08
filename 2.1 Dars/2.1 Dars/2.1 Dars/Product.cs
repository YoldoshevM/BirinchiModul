using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace _2._1_Dars;

public class Product
{

    public Guid ProductId { get; set; }

    public string Name { get; set; }

    public int Price { get; set; }

    public DateTime StartPeriod { get; set; }

    public DateTime EndPeriod { get; set; }



    
    public void PrintAllInfo()
    {

        Console.Write($" ID : {ProductId}");
        Console.Write($" Name : {Name}");
        Console.Write($" Price : {Price}");
        Console.Write($" StartPeriod : {StartPeriod}");
        Console.Write($" EndPeriod : {EndPeriod}");


    }







    public override string ToString()
    {

        return $"ID : {ProductId}\nProductID : {Name}\nLN : {Price}\nEmail : {StartPeriod}\nPhone : {EndPeriod}";

    }


}
