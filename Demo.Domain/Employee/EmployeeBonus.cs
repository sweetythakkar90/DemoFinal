using System;
using Hourly.Interface.Employee;

namespace Hourly.Domain.Employee
{
    public class EmployeeBonus: IEmployeeBonus
    {
        public int EmployeeId { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int DepartmentId { get; set; }
        public decimal BonusAmount { get; set; }
        public DateTime BonusDate { get; set; }
        public bool Status { get; set; }
        public string BonusRemarks { get; set; }
        public DateTime WhenCreated { get; set; }
        public DateTime WhenChanged { get; set; }
        public int ChangedBy { get; set; }
    }
}
