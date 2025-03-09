using MedCenter_API_CSharp.Models.Generic;

namespace MedCenter_API_CSharp.Models;

public class Leave : GenericEntity
{
    public Doctor Doctor { get; set; }

    public LeaveReason LeaveReason { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public Leave(long id, Doctor doctor, LeaveReason leaveReason, DateOnly startDate, DateOnly endDate)
    {
        Id = id;
        Doctor = doctor;
        LeaveReason = leaveReason;
        StartDate = startDate;
        EndDate = endDate;
    }
}