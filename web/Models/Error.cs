namespace web.Models;

public class Error
{
    public Error(string status, string message)
    {
        Status = status;
        Message = message;
    }

    public string Status { get; set; }
    public string Message { get; set; }
}