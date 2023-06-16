using web.Models;

namespace web.Services.Http.Auth;

public interface IAuthClient
{
    Task<Models.AuthenticationToken> SignIn(Login loginModel);
    Task<Models.Error> SignUp(User userModel);

}