using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Domain.Role;
using Demo.Interface.Role;

namespace Demo.Repository
{
    public class RoleRepository : IRoleRepository
    {
        public IRole GetRole(int roleId)
        {
            return GetRoleById(roleId);
        }

        private IRole GetRoleById(int roleId)
        {
            IRole role = new Role();
            role.RoleId = 123;
            return role;
        }
    }
}
