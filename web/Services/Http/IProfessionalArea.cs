using web.Models;

namespace web.Services.Http;

public interface IProfessionalArea
{
    Task<Error?> AddProfessionalArea(Models.ProfessionalArea professionalAreaModel, string bearerToken);
    Task<Error?> GetProfessionalAreaById(Models.ProfessionalArea professionalAreaModel, string bearerToken, int id);
}