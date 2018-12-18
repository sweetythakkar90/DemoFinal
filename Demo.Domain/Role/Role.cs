using System;
using Hourly.Interface.Role;

namespace Hourly.Domain.Role
{
    public class Role: IRole
    {
        public int RoleId { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int DepartmentId { get; set; }
        public string RoleName { get; set; }
        public string RoleDesc { get; set; }
        public bool Status { get; set; }
        public DateTime WhenCreated { get; set; }
        public DateTime WhenChanged { get; set; }
        public int ChangedBy { get; set; }
    }
}
