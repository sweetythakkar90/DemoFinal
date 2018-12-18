using System;
using Hourly.Interface.Misc;

namespace Hourly.Domain.Misc
{
    public class LeaveTypes : ILeaveTypes
    {
        public int LeaveTypeId { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int DepartmentId { get; set; }
        public string LeaveTypeName { get; set; }
        public string LeaveTypeDesc { get; set; }
        public bool Status { get; set; }
        public DateTime WhenCreated { get; set; }
        public DateTime WhenChanged { get; set; }
        public int ChangedBy { get; set; }
    }
}
