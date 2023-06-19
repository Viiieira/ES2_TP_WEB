using web.Models;

namespace web.Services.Http;

public interface IProfessionalArea
{
    Task<Error?> AddProfessionalArea(Models.ProfessionalArea professionalAreaModel, string bearerToken);
    Task<Error?> DeleteProfessionalArea(int id, string bearerToken);
    Task<Models.ProfessionalArea> GetProfessionalAreaById(int id, string bearerToken);
    Task<IOrderedEnumerable<Models.ProfessionalArea>> GetAllProfesionalAreas(string bearerToken);
}