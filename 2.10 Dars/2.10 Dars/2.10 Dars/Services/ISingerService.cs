using _2._10_Dars.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2._10_Dars.Services;

public interface ISingerService
{

    public Guid AddSiger(SingerCreateDto singerCreateDto);

    public SingerGetDto? GetSingerById(Guid singerId);

    public List<SingerGetDto> GetAllSingers();

    public void DeleteSinger ( Guid singerId);

    public SingerGetDto? GetSingerWithMaxPlays();
    public SingerGetDto? GetSingerWithMaxMusic();
    public SingerGetDto? GetSingerWithMaxAward();
    public SingerGetDto? GetSingerWithMinPlays();
    public SingerGetDto? GetSingerWithMinMusic();
    public SingerGetDto? GetSingerWithMinAward();
    public List<SingerGetDto> GetTopSingersWithMaxPlays(int count);
    public List<SingerGetDto> GetTopSingersWithMinPlays(int count);
    public List<SingerGetDto> GetSingersByGenre(string genre);



}
