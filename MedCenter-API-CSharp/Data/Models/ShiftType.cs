namespace MedCenter_API_CSharp.Models;

public class ShiftType
{
    public long Id { get; set; }
    public TimeOnly StartTime { get; set; }

    public TimeOnly EndTime { get; set; }

    public ShiftType(long id, TimeOnly startTime, TimeOnly endTime)
    {
        Id = id;
        StartTime = startTime;
        EndTime = endTime;
    }
}