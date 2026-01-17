using _2._5_Dars.Models;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;

namespace _2._5_Dars.Services;

public class AirLineService : IAirLineService
{

    List<AirLine> airlines;

    public AirLineService()
    {
        airlines = new List<AirLine>(); 
    }


    public Guid AddAirLine(AirLine airLine)
    {
        airLine.AirLineID = Guid.NewGuid();
        airlines.Add(airLine);
        return airLine.AirLineID;
    }

    public bool DeleteAirLine(Guid AirLineID)
    {
        foreach ( var airline in airlines )
        {
            if ( airline.AirLineID == AirLineID )
            {
                airlines.Remove( airline );
                return true;
            }
        }
        return false;
    }

    public AirLine? GetAirLineById(Guid AirLineID)
    {
        foreach ( var airline in airlines )
        {
            if (  airline.AirLineID == AirLineID )
            {
                return airline; 
            }
        }
        return null;
    }

    public List<AirLine> GetAllAirLines()
    {
        return airlines;
    }

    public bool UpgradeAirLine(AirLine UpdatingairLine)
    {

        foreach ( var airline in airlines )
        {
            if ( airline.AirLineID ==  UpdatingairLine.AirLineID)
            {
                airline.Name = UpdatingairLine.Name;    
                airline.Country = UpdatingairLine.Country;    
                airline.PlanesCount = UpdatingairLine.PlanesCount;    
                airline.IsInternational = UpdatingairLine.IsInternational;    
                airline.IsActive = UpdatingairLine.IsActive; 
                return true;
            }
        }
        return false;
    }
}
