using System;

namespace Hourly.Interface.Misc
{
    public interface ILeaveTypes
    {
        int LeaveTypeId { get; set; }
        int CompanyId { get; set; }
        int BranchId { get; set; }
        int DepartmentId { get; set; }
        string LeaveTypeName { get; set; }
        string LeaveTypeDesc { get; set; }
        bool Status { get; set; }
        DateTime WhenCreated { get; set; }
        DateTime WhenChanged { get; set; }
        int ChangedBy { get; set; }
    }
}
