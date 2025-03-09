using MedCenter_API_CSharp.Models.Generic;

namespace MedCenter_API_CSharp.Models;

public class ShiftType : GenericEntity
{
    private TimeOnly _startTime;
    private TimeOnly _endTime;
    
    public TimeOnly StartTime{get => _startTime; set => _startTime = value; }
    public TimeOnly EndTime{get => _endTime; set => _endTime = value; }

    public ShiftType(TimeOnly startTime, TimeOnly endTime) {
        _startTime = startTime;
        _endTime = endTime;
    }
}