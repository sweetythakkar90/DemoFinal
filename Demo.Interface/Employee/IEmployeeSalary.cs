using System;

namespace Hourly.Interface.Employee
{
    public interface IEmployeeSalary
    {
        int EmployeeId { get; set; }
        int CompanyId { get; set; }
        int BranchId { get; set; }
        int DepartmentId { get; set; }
        decimal SalaryAmount { get; set; }
        string SalaryFrequency { get; set; }
        bool Status { get; set; }
        DateTime DateApplied { get; set; }
        string SalaryRemarks { get; set; }
        DateTime WhenCreated { get; set; }
        DateTime WhenChanged { get; set; }
        int ChangedBy { get; set; }
    }
}
