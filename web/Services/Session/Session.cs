using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using web.Models;

namespace web.Services.Session;

public class Session : ISession
{
    private ProtectedSessionStorage _protectedSessionStorage;

    public Session(ProtectedSessionStorage protectedSessionStorage)
    {
        _protectedSessionStorage = protectedSessionStorage;
    }


    public async Task<AuthenticationToken> LoadStateAsync()
    {
        var result = await _protectedSessionStorage.GetAsync<AuthenticationToken>("User");
        if (result.Success && !result.Value.UserId.Equals(0))
        {
            return result.Value;
        }

        return null;
    }

    public async Task SetStateAsync(AuthenticationToken user)
    {
        await _protectedSessionStorage.SetAsync("User", user);
    }

    public async Task DeleteStateAsync()
    {
        await _protectedSessionStorage.DeleteAsync("User");
    }
}