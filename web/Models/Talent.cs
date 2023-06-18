namespace web.Models;

public class Talent
{
    public Talent()
    {
    }
    
    public Talent(int id, int idUser, int idTalentCategory, string name, double pricePerHour, bool @private)
    {
        Id = id;
        IdUser = idUser;
        IdTalentCategory = idTalentCategory;
        Name = name;
        PricePerHour = pricePerHour;
        Private = @private;
    }

    public int Id { get; set; }

    public int IdUser { get; set; }
    
    public int IdTalentCategory { get; set; }

    public string Name { get; set; }

    public double PricePerHour { get; set; }

    public bool Private { get; set; }
}