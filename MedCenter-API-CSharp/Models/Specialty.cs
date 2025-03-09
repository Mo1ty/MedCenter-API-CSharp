using MedCenter_API_CSharp.Models.Generic;

namespace MedCenter_API_CSharp.Models;

public class Specialty : GenericEntity
{
    private string _name;
    private string _description;
    
    public string Name{get => _name; set => _name = value;}
    public string Description{get => _description; set => _description = value;}

    public Specialty(string name, string description) {
        _name = name;
        _description = description;
    }
}