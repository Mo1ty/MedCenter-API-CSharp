using System.Reflection.Metadata;
using MedCenter_API_CSharp.Models.Generic;

namespace MedCenter_API_CSharp.Models;

public class Doctor : GenericEntity
{
    private string _contact;
    private ShiftType _shiftType;
    private string _cabinet;

    public string Contact { get => _contact; set => _contact = value; }
    public ShiftType ShiftType { get => _shiftType; set => _shiftType = value; }
    public string Cabinet { get => _cabinet; set => _cabinet = value; }

    public Doctor(string contact, ShiftType shiftType, string cabinet) {
        _contact = contact;
        _shiftType = shiftType;
        _cabinet = cabinet;
    }
}