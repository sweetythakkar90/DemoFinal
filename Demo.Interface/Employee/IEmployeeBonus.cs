using System;

namespace Hourly.Interface.Employee
{
    public interface IEmployeeBonus
    {
        int EmployeeId { get; set; }
        int CompanyId { get; set; }
        int BranchId { get; set; }
        int DepartmentId { get; set; }
        decimal BonusAmount { get; set; }
        DateTime BonusDate { get; set; }
        bool Status { get; set; }
        string BonusRemarks { get; set; }
        DateTime WhenCreated { get; set; }
        DateTime WhenChanged { get; set; }
        int ChangedBy { get; set; }
    }
}
