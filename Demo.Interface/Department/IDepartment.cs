using System;

namespace Hourly.Interface.Department
{
    public interface IDepartment
    {
        int DepartmentId { get; set; }
        string DepartmentName { get; set; }
        string DepartmentDescription { get; set; }
        int BranchId { get; set; }
        int CompanyId { get; set; }
        string ColorCode { get; set; }
        bool Status { get; set; }
        DateTime WhenCreated { get; set; }
        DateTime WhenChanged { get; set; }
        int ChangedBy { get; set; }

    }
}
