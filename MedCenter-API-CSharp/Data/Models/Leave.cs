using MedCenter_API_CSharp.Models.Generic;

namespace MedCenter_API_CSharp.Models;

public class Leave : GenericEntity
{

    public long DoctorId { get; set; }
    public Doctor Doctor { get; set; } = null!;

    public long LeaveReasonId { get; set; }
    public LeaveReason LeaveReason { get; set; } = null!;

    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }


    public Leave(long id, long doctorId, long leaveReasonId, DateOnly startDate, DateOnly endDate)
    {
        Id = id;
        DoctorId = doctorId;
        LeaveReasonId = leaveReasonId;
        StartDate = startDate;
        EndDate = endDate;
    }

}