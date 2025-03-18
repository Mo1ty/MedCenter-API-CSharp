namespace MedCenter_API_CSharp.Models;

public class Treatment
{
    public long Id { get; set; }
    public Specialty? Specialty { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public short Duration { get; set; }

    public Treatment(long id, Specialty? specialty, string name, string description, short duration)
    {
        Id = id;
        Specialty = specialty;
        Name = name;
        Description = description;
        Duration = duration;
    }
}