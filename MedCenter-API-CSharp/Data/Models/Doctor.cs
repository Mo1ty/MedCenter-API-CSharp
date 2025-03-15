using MedCenter_API_CSharp.Models.Generic;

namespace MedCenter_API_CSharp.Models;

public class Doctor : GenericEntity
{
    public string Cabinet { get; set; }
    
    // id field
    public long ContactId { get; set; }
    public string Contact { get; set; }
    
    public long ShiftTypeId { get; set; }
    public ShiftType ShiftType { get; set; }

    public Doctor(long id, string cabinet, long contactId, long shiftTypeId)
    {
        Id = id;
        Cabinet = cabinet;
        ContactId = contactId;
        ShiftTypeId = shiftTypeId;
    }
}