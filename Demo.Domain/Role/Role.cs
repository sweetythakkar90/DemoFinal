using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Interface.Role;

namespace Demo.Domain.Role
{
    public class Role: IRole
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDesc { get; set; }
        public int CompanyId { get; set; }
        public bool Status { get; set; }
    }
}
