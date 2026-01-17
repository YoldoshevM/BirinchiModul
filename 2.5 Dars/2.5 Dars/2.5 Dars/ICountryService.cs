using System;
using System.Collections.Generic;
using System.Text;

namespace _2._5_Dars;

public interface ICountryService
{

    public Guid AddCountry(Country county);
    public bool UpdateCountry(Country county);
    public bool DeleteCountry(Guid countryId);
    public Country? GetCountryById(Guid countryId);
    public List<Country> GetAllCountries();

}
