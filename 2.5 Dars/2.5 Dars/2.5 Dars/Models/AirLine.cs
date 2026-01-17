using System;
using System.Collections.Generic;
using System.Text;

namespace _2._5_Dars.Models;

public class AirLine
{

    public Guid AirLineID { get; set; }

    public string Name { get; set; }

    public string Country { get; set; }

    public int PlanesCount { get; set; }
    public bool IsInternational { get; set; }
    public bool IsActive { get; set; }



}
