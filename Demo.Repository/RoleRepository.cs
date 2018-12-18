using Hourly.Domain.Role;
using Hourly.Interface.Role;

namespace Hourly.Repository
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
