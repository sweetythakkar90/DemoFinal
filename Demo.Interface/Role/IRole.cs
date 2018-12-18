using System;

namespace Hourly.Interface.Role
{
    public interface IRole
    {
        int RoleId { get; set; }
        int CompanyId { get; set; }
        int BranchId { get; set; }
        int DepartmentId { get; set; }
        string RoleName { get; set; }
        string RoleDesc { get; set; }
        bool Status { get; set; }
        DateTime WhenCreated { get; set; }
        DateTime WhenChanged { get; set; }
        int ChangedBy { get; set; }
    }
}
