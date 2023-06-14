namespace web.Session;

public class Session
{
    public Session()
    {
    }

    public int UserId { get; set; }
    public string Role { get; set; }
    public string Username { get; set; }
    public string Token { get; set; }
}