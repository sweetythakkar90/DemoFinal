using System;
using Hourly.Interface.Department;

namespace Hourly.Domain.Department
{
    public class Department : IDepartment
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentDescription { get; set; }
        public int BranchId { get; set; }
        public int CompanyId { get; set; }
        public string ColorCode { get; set; }
        public bool Status { get; set; }
        public DateTime WhenCreated { get; set; }
        public DateTime WhenChanged { get; set; }
        public int ChangedBy { get; set; }
    }
}
