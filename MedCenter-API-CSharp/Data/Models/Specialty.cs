namespace MedCenter_API_CSharp.Models;

public class Specialty
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public Specialty(long id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
    }
}