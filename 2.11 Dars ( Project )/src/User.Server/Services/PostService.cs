using User.Server.Dtos;

namespace User.Server.Services;

public class PostService : IPostService
{
    public Guid AddPost(PostCreateDto postCreateDto, string token)
    {
        throw new NotImplementedException();
    }

    public bool DeletePost(Guid postId, string token)
    {
        throw new NotImplementedException();
    }

    public List<PostGetDto> GetAllPosts(string token)
    {
        throw new NotImplementedException();
    }

    public List<PostGetDto> GetAllPostsByAdmin(string token)
    {
        throw new NotImplementedException();
    }

    public PostGetDto? GetPostById(Guid postId)
    {
        throw new NotImplementedException();
    }

    public bool UpdatePost(Guid postId, PostCreateDto postCreateDto, string token)
    {
        throw new NotImplementedException();
    }
}
