using _2._5_Dars.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2._5_Dars.Services;

public interface ISingerService
{


    public Guid AddSinger(Singer singer);

    public bool DeleteSinger(Guid SingerID);

    public bool UpgradeSinger(Singer singer);

    public Singer? GetSingerById(Guid SingerID);

    public List<Singer> GetAllSingers();
    





}
