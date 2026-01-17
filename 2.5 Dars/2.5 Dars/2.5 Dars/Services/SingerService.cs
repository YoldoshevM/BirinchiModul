using _2._5_Dars.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace _2._5_Dars.Services;

public class SingerService : ISingerService
{

    List<Singer> singers;

    public SingerService()
    {
        singers = new List<Singer>();
    }

    public Guid AddSinger(Singer singer)
    {
        singer.SingerId = Guid.NewGuid();
        singers.Add(singer);
        return singer.SingerId;
        
    }

    public bool DeleteSinger(Guid SingerID)
    {
        foreach ( Singer singer in singers)
        {
            if ( singer.SingerId == SingerID )
            {
                singers.Remove(singer);
                return true;
            }
        }
        return false;
    }

    public List<Singer> GetAllSingers()
    {
        return singers;
    }

    public Singer? GetSingerById(Guid SingerID)
    {
        foreach( Singer singer in singers)
        {
            if ( singer.SingerId == SingerID )
            {
                return singer; 
            }
        }
        return null;
    }

    public bool UpgradeSinger(Singer Updatingsinger)
    {
        
        foreach( Singer singer in singers)
        {
            if ( singer.SingerId == Updatingsinger.SingerId )
            {
                
                singer.FirstName = Updatingsinger.FirstName;
                singer.LastName = Updatingsinger.LastName;
                singer.NumberOfMusics = Updatingsinger.NumberOfMusics;
                singer.Country = Updatingsinger.Country;    
                return true;
            }
        }
        return false;
    }
}
