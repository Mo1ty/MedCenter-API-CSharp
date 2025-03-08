using MedCenter_API_CSharp.Models.Generic;

namespace MedCenter_API_CSharp.Models;

public class LeaveReason : GenericEntity
{
    private string _name;
    private string _description;

    public string Name {
        get { return _name; }
        set { _name = value; }
    }
    
    public string Description {
        get { return _description; }
        set { _description = value; }
    }

    public LeaveReason(string name) {
        _name = name;
        _description = "";
    }

    public LeaveReason(string name, string description) {
        _name = name;
        _description = description;
    }
}