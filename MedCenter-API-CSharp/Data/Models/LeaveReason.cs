namespace MedCenter_API_CSharp.Models;

public class LeaveReason
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public LeaveReason(long id, string name)
    {
        Id = id;
        Name = name;
        Description = "";
    }

    public LeaveReason(long id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
    }
}