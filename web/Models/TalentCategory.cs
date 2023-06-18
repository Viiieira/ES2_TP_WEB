namespace web.Models;

public class TalentCategory
{
    public TalentCategory()
    {
    }

    public TalentCategory(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public int Id { get; set; }
    public string Name { get; set; }
}