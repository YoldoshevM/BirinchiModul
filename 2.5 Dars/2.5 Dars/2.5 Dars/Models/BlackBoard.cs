using System;
using System.Collections.Generic;
using System.Text;

namespace _2._5_Dars.Models;

public class BlackBoard
{

    public Guid BlackBoardId { get; set; }
    public string Color { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public string Material { get; set; }
    public bool IsClean { get; set; }


}
