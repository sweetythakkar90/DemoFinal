using System;
using Hourly.Interface.Employee;

namespace Hourly.Domain.Employee
{
    public class EmployeeSalary : IEmployeeSalary
    {
        public int EmployeeId { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int DepartmentId { get; set; }
        public decimal SalaryAmount { get; set; }
        public string SalaryFrequency { get; set; }
        public bool Status { get; set; }
        public DateTime DateApplied { get; set; }
        public string SalaryRemarks { get; set; }
        public DateTime WhenCreated { get; set; }
        public DateTime WhenChanged { get; set; }
        public int ChangedBy { get; set; }
    }
}
