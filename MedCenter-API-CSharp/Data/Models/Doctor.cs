using System.Reflection.Metadata;
using MedCenter_API_CSharp.Models.Generic;

namespace MedCenter_API_CSharp.Models;

public class Doctor : GenericEntity
{

    public long ContactId { get; set; }
    public string Contact { get; set; } = null!;

    public long ShiftTypeId { get; set; }
    public ShiftType ShiftType { get; set; } = null!;

    public string Cabinet { get; set; }

    public List<Specialty>? Specialties { get; set; }


    public Doctor(long id, long contactId, long shiftTypeId, string cabinet)
    {
        Id = id;
        ContactId = contactId;
        ShiftTypeId = shiftTypeId;
        Cabinet = cabinet;
    }

}