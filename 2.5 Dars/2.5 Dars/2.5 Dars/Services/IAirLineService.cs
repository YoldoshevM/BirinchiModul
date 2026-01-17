using _2._5_Dars.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2._5_Dars.Services;

public interface IAirLineService
{

    public Guid AddAirLine(AirLine airLine);

    public bool DeleteAirLine(Guid AirLineID);

    public bool UpgradeAirLine(AirLine airLine);

    public AirLine? GetAirLineById(Guid AirLineID);

    public List<AirLine> GetAllAirLines();




}
