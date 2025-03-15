using MedCenter_API_CSharp.Models.Generic;

namespace MedCenter_API_CSharp.Models;

public class Treatment : GenericEntity
{
    
    public string Name { get; set; }
    public string Description { get; set; }
    public short Duration { get; set; }
    
    public long? SpecialtyId { get; set; }
    public Specialty? Specialty { get; set; }

    public Treatment(long id, string name, string description, short duration, long? specialtyId)
    {
        Id = id;
        Name = name;
        Description = description;
        Duration = duration;
        SpecialtyId = specialtyId;
    }
}