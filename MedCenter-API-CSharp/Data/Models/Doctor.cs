namespace MedCenter_API_CSharp.Models;

public class Doctor
{
    public long Id { get; set; }
    public string Contact { get; set; }
    public ShiftType ShiftType { get; set; }
    public string Cabinet { get; set; }

    public Doctor(long id, string contact, ShiftType shiftType, string cabinet)
    {
        Id = id;
        Contact = contact;
        ShiftType = shiftType;
        Cabinet = cabinet;
    }
}