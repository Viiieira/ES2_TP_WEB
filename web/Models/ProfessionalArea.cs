namespace web.Models;

public class ProfessionalArea
{
    public ProfessionalArea() {}

    public ProfessionalArea(string area)
    {
        Area = area;
    }

    public string Area { get; set; }
}