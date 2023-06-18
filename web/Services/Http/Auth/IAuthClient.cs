using web.Models;

namespace web.Services.Http.Auth;

public interface IAuthClient
{
    Task<AuthenticationToken> SignIn(Login loginModel);
    Task<Error> SignUp(User userModel);

}