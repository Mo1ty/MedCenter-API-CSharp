using MedCenter_API_CSharp.Models.Generic;

namespace MedCenter_API_CSharp.Models;

public class ShiftType : GenericEntity
{

    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }


    public ShiftType(long id, TimeOnly startTime, TimeOnly endTime)
    {
        Id = id;
        StartTime = startTime;
        EndTime = endTime;
    }

}