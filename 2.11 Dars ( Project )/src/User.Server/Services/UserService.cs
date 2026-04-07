using User.Server.Dtos;

namespace User.Server.Entities;

public class UserService : IUserService
{
    public bool BlockUser(Guid userId, string token)
    {
        throw new NotImplementedException();
    }

    public bool ChangeRole(Guid userId, string token)
    {
        throw new NotImplementedException();
    }

    public bool DeleteUser(Guid userId, string token)
    {
        throw new NotImplementedException();
    }

    public bool DeleteUserPost(Guid postId, string token)
    {
        throw new NotImplementedException();
    }

    public List<UserGetDto> GetAllUsers(Guid userID, string token)
    {
        throw new NotImplementedException();
    }
}
