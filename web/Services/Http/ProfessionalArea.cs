using System.Net;
using System.Net.Http.Headers;
using web.Models;

namespace web.Services.Http;

public class ProfessionalArea : IProfessionalArea
{
    private HttpClient _httpClient;
    private const string ApiUrl = "areas/";

    public ProfessionalArea(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri("http://localhost:8000/api/");
        _httpClient.Timeout = new TimeSpan(0, 0, 50);
    }
    
    public async Task<Error?> AddProfessionalArea(Models.ProfessionalArea professionalAreaModel, string bearerToken)
    {
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);
        var response = await _httpClient.PostAsJsonAsync<Models.ProfessionalArea>(ApiUrl, professionalAreaModel);
        if (response.IsSuccessStatusCode)
        {
            return null;
        }

        var addResponse = await response.Content.ReadFromJsonAsync<Error>();
        return addResponse;
    }

    public async Task<Error?> DeleteProfessionalArea(int id, string bearerToken)
    {
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);
    
        var response = await _httpClient.DeleteAsync($"{ApiUrl}{id}");

        if (response.IsSuccessStatusCode)
        {
            return null;
        }

        var deleteResponse = await response.Content.ReadFromJsonAsync<Error>();
        return deleteResponse;
    }
}