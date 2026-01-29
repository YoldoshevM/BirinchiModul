using _2ModulExam.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2ModulExam.Services;

public interface IMusicService
{


    public Guid AddMusic(MusicCreateDto musicCreateDto);

    public bool DeleteMusic(Guid musicId);

    public MusicCreateDto? GetMusicByID (Guid musicId);

    public List<MusicCreateDto> GetAllMusics();


    public List<MusicCreateDto> GetAllMusicByAuthorName(string name);
    public List<MusicCreateDto> GetMostLikedMusic();
    public List<MusicCreateDto> GetMusicByName(string name);
    public List<MusicCreateDto> GetAllMinMusicAboveSize(double minSize);
    public List<MusicCreateDto> GetAllMaxMusicAboveSize(double minSize);
    public List<MusicCreateDto> GetTopMostLikeMusic(int count);
    public List<MusicCreateDto> GetMusicWithLikesInRange(int minLikes , int maxLikes);
    public double GetTotalMusicSizeByAutor(string autorName);





}
