using web.Models;

namespace web.Services.Http.Auth;

public class AuthClient : IAuthClient
{
    private HttpClient _httpClient;
    private const string apiUrl = "auth/";

    public AuthClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri("http://localhost:8000/api/");
        _httpClient.Timeout = new TimeSpan(0, 0, 50);
    }

    public async Task<Models.AuthenticationToken> SignIn(Login loginModel)
    {
        var response = await _httpClient.PostAsJsonAsync<Models.Login>(apiUrl + "signin/", loginModel);
        if (response is not null && response.IsSuccessStatusCode)
        {
            var loginResponse = await response.Content.ReadFromJsonAsync<Models.AuthenticationToken>();
            return loginResponse;
        }

        return null;
    }

    public async Task<Error> SignUp(User userModel)
    {
        var response = await _httpClient.PostAsJsonAsync<Models.User>(apiUrl + "signup/", userModel);
        if (response is not null && response.IsSuccessStatusCode)
        {
            var loginResponse = await response.Content.ReadFromJsonAsync<Error>();
            return loginResponse;
        }

        return null;
    }
}