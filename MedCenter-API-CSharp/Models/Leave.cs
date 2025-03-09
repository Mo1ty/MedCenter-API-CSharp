using MedCenter_API_CSharp.Models.Generic;

namespace MedCenter_API_CSharp.Models;

public class Leave : GenericEntity
{
    private Doctor _doctor;
    private LeaveReason _leaveReason;
    private DateOnly _startDate;
    private DateOnly _endDate;
    
    public Doctor Doctor{get => _doctor; set => _doctor = value;}
    public LeaveReason LeaveReason{get => _leaveReason; set => _leaveReason = value;}
    public DateOnly StartDate{get => _startDate; set => _startDate = value;}
    public DateOnly EndDate{get => _endDate; set => _endDate = value;}

    public Leave(Doctor doctor, LeaveReason leaveReason, DateOnly startDate, DateOnly endDate) {
        _doctor = doctor;
        _leaveReason = leaveReason;
        _startDate = startDate;
        _endDate = endDate;
    }
}