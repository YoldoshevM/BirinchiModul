using System;
using System.Collections.Generic;
using System.Text;

namespace _2._5_Dars;

public class CountryService : ICountryService
{

    List<Country> Countries;

    public CountryService()
    {
        Countries = new List<Country>();
    }

    public Guid AddCountry(Country county)
    {        

        county.CoutryId = Guid.NewGuid();
        Countries.Add(county);
        return county.CoutryId;

    }

    public bool DeleteCountry(Guid countryId)
    {
        
        foreach ( var country in Countries )
        {
            if ( country.CoutryId == countryId )
            {
                Countries.Remove(country);
                return true;
            }
        }
        return false;
    }

    public List<Country> GetAllCountries()
    {
        return Countries;
    }

    public Country? GetCountryById(Guid countryId)
    {
        foreach (var country in Countries )
        {
       
            if ( country.CoutryId == countryId )
            {
                return country;
            }
        }
        return null;
    }

    public bool UpdateCountry(Country county)
    {
        
        foreach ( var country in Countries )
        {
            if ( country.CoutryId == county.CoutryId )
            {
                country.Name = county.Name;
                country.Compasity = county.Compasity;
                country.CountOfPeople = county.CountOfPeople;
            }
                return true;
        }
        return false;
    }
}
