namespace web.Services.Http.Talent;

public class Talent : ITalent
{
    private HttpClient _httpClient;
    private const string ApiUrl = "areas/";

    public Talent(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri("http://localhost:8000/api/");
        _httpClient.Timeout = new TimeSpan(0, 0, 50);
    }
}