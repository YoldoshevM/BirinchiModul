using _2._10_Dars.Dtos;
using _2._10_Dars.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2._10_Dars.Services;

public class SingerService : ISingerService
{

    List<Singer> singers;

    public SingerService()
    {
        singers = new List<Singer>();
    }

    public Guid AddSiger(SingerCreateDto singerCreateDto)
    {

        var singer = new Singer()
        {

            SingerId = Guid.NewGuid(),
            FirstName = singerCreateDto.FirstName,
            LastName = singerCreateDto.LastName,
            SingerName = singerCreateDto.SingerName,
            Password = singerCreateDto.Password,
            MusicNames = singerCreateDto.MusicNames,
            Genres = singerCreateDto.Genres,
            Awards = singerCreateDto.Awards,
            TotalPlays = 0

        };

        singers.Add(singer);
        return singer.SingerId;

    }

    public void DeleteSinger(Guid singerId)
    {
        foreach ( var singer in singers)
        {
            if ( singer.SingerId == singerId )
            {
                singers.Remove(singer); 
            }
        }
    }

    public List<SingerGetDto> GetAllSingers()
    {
        var singerGetDtos = ToSingerGetDtos(singers);
        return singerGetDtos;
    }

    public SingerGetDto? GetSingerById(Guid singerId)
    {
        
        foreach ( var singer in singers)
        {
            
            if ( singer.SingerId == singerId )
            {
                return ToSingerGetDto(singer);
            }
        }
        return null;
    }


    public List<SingerGetDto> GetSingersByGenre(string genre)
    {
        



    }

    public SingerGetDto? GetSingerWithMaxAward()
    {
        throw new NotImplementedException();
    }

    public SingerGetDto? GetSingerWithMaxMusic()
    {
        throw new NotImplementedException();
    }

    public SingerGetDto? GetSingerWithMaxPlays()
    {
        throw new NotImplementedException();
    }

    public SingerGetDto? GetSingerWithMinAward()
    {
        throw new NotImplementedException();
    }

    public SingerGetDto? GetSingerWithMinMusic()
    {
        throw new NotImplementedException();
    }

    public SingerGetDto? GetSingerWithMinPlays()
    {
        throw new NotImplementedException();
    }

    public List<SingerGetDto> GetTopSingersWithMaxPlays(int count)
    {
        throw new NotImplementedException();
    }

    public List<SingerGetDto> GetTopSingersWithMinPlays(int count)
    {
        throw new NotImplementedException();
    }

    public bool UpdateSinger(SingerUpdateDto singerUpdateDto, Guid singerID)
    {
        throw new NotImplementedException();
    }







    private SingerGetDto ToSingerGetDto(Singer singer)
    {


        return new SingerGetDto()
        {

            SingerId = singer.SingerId,
            FirstName = singer.FirstName,
            LastName = singer.LastName,
            SingerName = singer.SingerName,
            MusicNames = singer.MusicNames,
            Genres = singer.Genres,
            Awards = singer.Awards,
            TotalPlays = singer.TotalPlays


        };


    }



    private List<SingerGetDto> ToSingerGetDtos ( List<Singer> singers)
    {

        var singerGetDtos = new List<SingerGetDto>();
        foreach (var singer in singers)
        {
            singerGetDtos.Add(ToSingerGetDto(singer));
        }

        return singerGetDtos;

    }
        




}




