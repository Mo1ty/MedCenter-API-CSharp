using MedCenter_API_CSharp.Models.Generic;

namespace MedCenter_API_CSharp.Models;

public class LeaveReason : GenericEntity
{

    public string Name { get; set; }
    public string Description { get; set; }


    public LeaveReason(long id, string name)
    {
        Id = id;
        Name = name;
        Description = string.Empty;
    }


    public LeaveReason(long id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
    }

}