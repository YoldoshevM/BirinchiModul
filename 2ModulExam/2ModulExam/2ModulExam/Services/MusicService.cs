using _2ModulExam.Dtos;
using _2ModulExam.Entites;

namespace _2ModulExam.Services;

public class MusicService : IMusicService
{

    List<Music> musics;

    public MusicService()
    {
        musics = new List<Music>();
    }

    public Guid AddMusic(MusicCreateDto musicCreateDto)
    {

        throw new NotImplementedException();

    }

    public bool DeleteMusic(Guid musicId)
    {
        foreach ( var music in musics)
        {
            if ( music.Id == musicId)
            {
                musics.Remove(music);
                return true;
            }
        }
        return false;
    }



    public MusicCreateDto? GetMusicByID(Guid musicId)
    {
        foreach( var music in musics)
        {
            if (music.Id == musicId)
            {
                music.Id = musicId;
            }
        }
        return null;
    }


    public List<MusicCreateDto> GetAllMusics()
    {
        return ToMusicGetDtos;
    }


    public List<MusicCreateDto> GetAllMusicByAuthorName(string name)
    {
        throw new NotImplementedException();
    }


    public List<MusicCreateDto> GetMostLikedMusic(int QuentityLikes)
    {
        foreach (var music in musics)
        {
            if (music.QuentityLikes < QuentityLikes )
            {
                return musics.Add(MusicGetDto(GetMostLikedMusic));
            }
        }
    }

    private Music GetMostLikedMusic(Music music)
    {
        throw new NotImplementedException();
    }

    public List<MusicCreateDto> GetAllMaxMusicAboveSize(double minSize)
    {
        throw new NotImplementedException();
    }

    public List<MusicCreateDto> GetAllMinMusicAboveSize(double minSize)
    {
        throw new NotImplementedException();
    }

    public List<MusicCreateDto> GetMusicByName(string name)
    {
        throw new NotImplementedException();
    }

    public List<MusicCreateDto> GetMusicWithLikesInRange(int minLikes, int maxLikes)
    {
        throw new NotImplementedException();
    }

    public List<MusicCreateDto> GetTopMostLikeMusic(int count)
    {
        foreach ( var music in musics)
        
            if ( music.QuentityLikes <  count )
            {
                return 
            }
    }
    

    public double GetTotalMusicSizeByAutor(string autorName)
    {
        throw new NotImplementedException();
    }




    private MusicGetDto ToMusicGetDto(Music musics)
    {

        var ToMusicGetDto = new MusicGetDto()
        {

            Id = musics.Id,
            Name = musics.Name,
            MB = musics.MB,
            AuthorName = musics.AuthorName,
            Describtion = musics.Describtion,
            QuentityLikes = musics.QuentityLikes,

        };

        return ToMusicGetDto;

    }

    public List<MusicCreateDto> GetMostLikedMusic()
    {
        throw new NotImplementedException();
    }
}
