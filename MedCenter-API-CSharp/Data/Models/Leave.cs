using MedCenter_API_CSharp.Models.Generic;

namespace MedCenter_API_CSharp.Models;

public class Leave : GenericEntity
{
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    
    public long DoctorId { get; set; }
    public Doctor Doctor { get; set; }

    public long LeaveReasonId { get; set; }
    public LeaveReason LeaveReason { get; set; }

    public Leave(long id, DateOnly startDate, DateOnly endDate, long doctorId, long leaveReasonId)
    {
        Id = id;
        StartDate = startDate;
        EndDate = endDate;
        DoctorId = doctorId;
        LeaveReasonId = leaveReasonId;
    }
}