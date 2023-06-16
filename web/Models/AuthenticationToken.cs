namespace web.Models;

public class AuthenticationToken
{
    public AuthenticationToken()
    {
        
    }

    public AuthenticationToken(string token, int userId, string username, string role)
    {
        Token = token;
        UserId = userId;
        Username = username;
        Role = role;
    }

    public string Token { get; set; }
    public int UserId { set; get; }
    public string Username { set; get; }
    public string Role { set; get; }
}