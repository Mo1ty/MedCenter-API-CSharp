using MedCenter_API_CSharp.Models.Generic;

namespace MedCenter_API_CSharp.Models;

public class Treatment : GenericEntity
{
    private Specialty? _specialty;
    private string _name;
    private string _description;
    private short _duration;
    
    public Specialty? Specialty{get => _specialty; set => _specialty = value;}
    public string Name { get => _name; set => _name = value; }
    public string Description { get => _description; set => _description = value; }
    public short Duration { get => _duration; set => _duration = value; }

    public Treatment(Specialty? specialty, string name, string description, short duration) {
        _specialty = specialty;
        _name = name;
        _description = description;
        _duration = duration;
    }
}