using MedCenter_API_CSharp.Models.Generic;

namespace MedCenter_API_CSharp.Models;

public class Treatment : GenericEntity
{

    public long? SpecialtyId { get; set; }
    public Specialty? Specialty { get; set; }

    public string Name { get; set; }
    public string Description { get; set; }
    public short Duration { get; set; }


    public Treatment(long id, long? specialtyId, string name, string description, short duration)
    {
        Id = id;
        SpecialtyId = specialtyId;
        Name = name;
        Description = description;
        Duration = duration;
    }

}