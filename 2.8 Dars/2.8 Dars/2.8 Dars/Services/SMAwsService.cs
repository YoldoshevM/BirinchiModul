using _2._8_Dars.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2._8_Dars.Services;

public class SMAwsService : ISocialMediaService
{

    List<SocialMedia> SocialMediasAws = new List<SocialMedia>();

    public Guid Add(SocialMedia socialMedia)
    {
        socialMedia.SocialMediaId = Guid.NewGuid();
        SocialMediasAws.Add(socialMedia);
        return socialMedia.SocialMediaId;
    }

    public bool Delete(Guid id)
    {
        foreach (var sM in SocialMediasAws)
        {
            if (sM.SocialMediaId == id)
            {
                SocialMediasAws.Remove(sM);
                return true;
            }
        }
        return false;
    }

    public List<SocialMedia> GetAll()
    {
        return SocialMediasAws;
    }

    public SocialMedia? GetById(Guid id)
    {
        foreach (var sM in SocialMediasAws)
        {
            if (sM.SocialMediaId == id)
            {
                return sM;
            }
        }

        return null;
    }

    public bool Update(Guid id, SocialMedia socialMedia)
    {
        foreach (var sM in SocialMediasAws)
        {
            if (sM.SocialMediaId == id)
            {
                sM.Name = socialMedia.Name;
                sM.Description = socialMedia.Description;
                sM.Ceo = socialMedia.Ceo;
                return true;
            }
        }

        return false;
    }

    public bool update(Guid id, SocialMedia socialMedia)
    {
        throw new NotImplementedException();
    }
}
