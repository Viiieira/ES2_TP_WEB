using web.Models;

namespace web.Services.Session;

public class Session : ISession
{
    private Blazored.SessionStorage.ISessionStorageService _sessionStorage;

    public Session(Blazored.SessionStorage.ISessionStorageService sessionStorage)
    {
        _sessionStorage = sessionStorage;
    }


    public async Task<AuthenticationToken> LoadStateAsync()
    {
        var result = await _sessionStorage.GetItemAsync<AuthenticationToken>("User");
        if (result is not null)
        {
            return result;
        }

        return null;
    }

    public async Task SetStateAsync(AuthenticationToken user)
    {
        await _sessionStorage.SetItemAsync("User", user);
    }

    public async Task DeleteStateAsync()
    {
        await _sessionStorage.RemoveItemAsync("User");
    }
}