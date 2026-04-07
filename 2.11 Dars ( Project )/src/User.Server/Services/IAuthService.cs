
using User.Server.Dtos;

namespace User.Server.Services;

public interface IAuthService
{

    public Guid RegisterUser(UserRegisterDto userRegisterDto);
    public string LoginUser(UserLoginDto userLoginDto);


}