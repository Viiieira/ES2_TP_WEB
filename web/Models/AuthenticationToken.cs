namespace web.Models;

public class AuthenticationToken
{
    public AuthenticationToken()
    {
    }

    public AuthenticationToken(string token)
    {
        Token = token;
    }

    public string Token { get; set; }
}