namespace web.Models;

public class ProfessionalArea
{
    public ProfessionalArea()
    {
    }

    public ProfessionalArea(int id, string area)
    {
        Id = id;
        Area = area;
    }

    public int Id { get; set; }
    public string Area { get; set; }
}