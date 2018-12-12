using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Interface.Misc;

namespace Demo.Domain.Misc
{
    public class LeaveApplication : ILeaveApplication
    {
        public int LeaveTypeId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime LeaveStartDate { get; set; }
        public DateTime LeaveEndDate { get; set; }
        public bool IsHalfDayLeave { get; set; }
        public DateTime? LeaveStartTime { get; set; }
        public DateTime? LeaveEndTime { get; set; }
        public int LeaveStatus { get; set; } //isApproved, isPendingApproval etc
        public DateTime WhenCreated { get; set; }
        public DateTime WhenChanged { get; set; }
        public int ChangedBy { get; set; }
    }
}
