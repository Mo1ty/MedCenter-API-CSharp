using MedCenter_API_CSharp.Models.Generic;

namespace MedCenter_API_CSharp.Models;

public class Specialty : GenericEntity
{
    public string Name { get; set; }
    public string Description { get; set; }

    public Specialty(long id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
    }
}