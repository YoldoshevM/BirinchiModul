using _2._6_Dars.Dtos;
using _2._6_Dars.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2._6_Dars.Services;

public class SingerService : ISingerService
{

    List<Singer> singers;

    public SingerService()
    {
        singers = new List<Singer>();   
    }


    public Guid AddSinger(SingerCreateDto singerCreateDto)
    {
        
        var singer = new Singer
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





    public bool DeleteSinger(Guid singerId)
    {
        
        foreach (var singer in singers)
        {
            if ( singer.SingerId == singerId)
            {
                singers.Remove(singer);
                return true;
            }
        }

        return false;

    }





    public List<SingerGetDto> GetAllSingers()
    {
        
        var singerGetDtos = ToSingerGetDtos(singers);
        return singerGetDtos;
    }





    public SingerGetDto? GetSingerById(Guid singerId)
    {
        
        foreach(var singer in singers)
        {
            if (singer.SingerId == singerId)
            {
                return ToSingerGetDto(singer);
            }
        }

        return null;
    }





    public List<SingerGetDto> GetSingersByGenre(string genre)
    {
        
        var singerGetDtos = new List<SingerGetDto>();

        foreach (var singer in singers)
        {
            if ( singer.Genres.Contains(genre))
            {
                singerGetDtos.Add(ToSingerGetDto(singer));
            }
        }


        return singerGetDtos;  
    }




    public SingerGetDto? GetSingerWithMaxAward()
    {
        //var singer = Singers.Max(s => s.Awards);
        if (singers.Count() == 0)
        {
            return null;
        }

        var singerWithMaxAward = singers[0];
        foreach (var singer in singers)
        {
            if (singerWithMaxAward.Awards.Count() < singer.Awards.Count())
            {
                singerWithMaxAward = singer;
            }
        }

        return ToSingerGetDto(singerWithMaxAward);
    }






    public SingerGetDto? GetSingerWithMaxMusic()
    {
        if (singers.Count() == 0)
        {
            return null;
        }

        var singerWithMaxMusic = singers[0];
        foreach (var singer in singers)
        {
            if (singerWithMaxMusic.MusicNames.Count() < singer.MusicNames.Count())
            {
                singerWithMaxMusic = singer;
            }
        }

        return ToSingerGetDto(singerWithMaxMusic);
    }





    public SingerCreateDto? GetSingerWithMaxPlays()
    {
        throw new NotImplementedException();
    }

    public SingerCreateDto? GetSingerWithMinAward()
    {

        if (singers.Count() == 0)
        {
            return null;
        }

        var singerWithMinMusic = singers[0];
        foreach (var singer in singers)
        {
            if (singerWithMinMusic.MusicNames.Count() < singer.MusicNames.Count())
            {
                singerWithMinMusic = singer;
            }
        }

        return ToSingerGetDto(singerWithMinMusic);

    }

    public SingerCreateDto? GetSingerWithMinMusic()
    {

        if (singers.Count() == 0)
        {
            return null;
        }

        var singerWithMinMusic = singers[0];
        foreach (var singer in singers)
        {
            if (singerWithMinMusic.MusicNames.Count() > singer.MusicNames.Count())
            {
                singerWithMinMusic = singer;
            }
        }

        return ToSingerGetDto(singerWithMinMusic);


    }

    public SingerCreateDto? GetSingerWithMinPlays()
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

    public bool UpdateSinger(Guid singerId, SingerUpdateDto singerUpdateDto)
    {
        throw new NotImplementedException();
    }

    SingerCreateDto? ISingerService.GetSingerWithMaxAward()
    {
        throw new NotImplementedException();
    }

    SingerCreateDto? ISingerService.GetSingerWithMaxMusic()
    {
        throw new NotImplementedException();
    }






















    private SingerGetDto ToSingerGetDto(Singer singer)
    {
        return new SingerGetDto
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


    private List<SingerGetDto> ToSingerGetDtos(List<Singer> singers)
    {
        var singerGetDtos = new List<SingerGetDto>();
        foreach (var singer in singers)
        {
            singerGetDtos.Add(ToSingerGetDto(singer));
        }

        return singerGetDtos;
    }
}
