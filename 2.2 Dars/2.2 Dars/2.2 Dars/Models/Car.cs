using System;
using System.Collections.Generic;
using System.Text;

namespace _2._2_Dars.Models;

internal class Car
{

    public Guid CarId { get; set; }
    
    public string Color { get; set; }

    public string Name { get; set; }

    public string Brand { get; set; }

    public int MaxSpeed { get; set; }

    public Decimal Price { get; set; }

}
