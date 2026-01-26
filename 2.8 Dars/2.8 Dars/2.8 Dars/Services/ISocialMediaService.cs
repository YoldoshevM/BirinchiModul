using _2._8_Dars.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2._8_Dars.Services;

public interface ISocialMediaService
{

    public Guid Add(SocialMedia socialMedia);

    public List<SocialMedia> GetAll();


    public SocialMedia? GetById(Guid id);

    public bool update(Guid id, SocialMedia socialMedia);

    public bool Delete(Guid id);



}
