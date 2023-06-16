using web.Models;

namespace web.Services.Session;

public interface ISession
{
    Task<AuthenticationToken> LoadStateAsync();
    Task SetStateAsync(AuthenticationToken user);
    Task DeleteStateAsync();
}