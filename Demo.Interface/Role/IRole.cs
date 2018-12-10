using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface.Role
{
    public interface IRole
    {
        int RoleId { get; set; }
        string RoleName { get; set; }
        string RoleDesc { get; set; }
        int CompanyId { get; set; }
        bool Status { get; set; }
    }
}
