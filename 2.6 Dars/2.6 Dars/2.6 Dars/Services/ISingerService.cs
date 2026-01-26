using _2._6_Dars.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2._6_Dars.Services;

public interface ISingerService
{


    public Guid AddSinger(SingerCreateDto singerCreateDto);


    public SingerGetDto? GetSingerById(Guid singerId);

    public List<SingerGetDto> GetAllSingers();


    public bool DeleteSinger(Guid singerId);

    public bool UpdateSinger(Guid singerId, SingerUpdateDto singerUpdateDto);


    public SingerCreateDto? GetSingerWithMaxPlays();
    public SingerCreateDto? GetSingerWithMaxMusic();
    public SingerCreateDto? GetSingerWithMaxAward();

    public SingerCreateDto? GetSingerWithMinPlays();
    public SingerCreateDto? GetSingerWithMinMusic();
    public SingerCreateDto? GetSingerWithMinAward();

    public List<SingerGetDto> GetTopSingersWithMaxPlays(int count);
    public List<SingerGetDto> GetTopSingersWithMinPlays(int count);
    public List<SingerGetDto> GetSingersByGenre(string genre);


}
