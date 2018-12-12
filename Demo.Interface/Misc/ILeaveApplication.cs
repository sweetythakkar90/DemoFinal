using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface.Misc
{
    public interface ILeaveApplication
    {
        int LeaveTypeId { get; set; }
        int EmployeeId { get; set; }
        DateTime LeaveStartDate { get; set; }
        DateTime LeaveEndDate { get; set; }
        bool IsHalfDayLeave { get; set; }
        DateTime? LeaveStartTime { get; set; }
        DateTime? LeaveEndTime { get; set; }
        int LeaveStatus { get; set; } //isApproved, isPendingApproval etc
        DateTime WhenCreated { get; set; }
        DateTime WhenChanged { get; set; }
        int ChangedBy { get; set; }

    }
}
