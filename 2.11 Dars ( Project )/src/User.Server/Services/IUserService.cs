using User.Server.Dtos;

namespace User.Server.Entities;

public interface IUserService
{

    public List<UserGetDto> GetAllUsers(Guid userID, string token);

    public bool DeleteUser(Guid userId, string token);

    public bool DeleteUserPost(Guid postId, string token);

    public bool BlockUser(Guid userId, string token);

    public bool ChangeRole(Guid userId, string token);

}