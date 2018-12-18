using System;
using Hourly.Interface.Role;

namespace Hourly.Domain.Role
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            if (roleRepository == null) throw new ArgumentNullException(nameof(roleRepository));
            _roleRepository = roleRepository;
        }
        public IRole GeRole(int roleId)
        {
            if (roleId <= 0)
                throw new Exception("Invalid role id");
            return _roleRepository.GetRole(roleId);
        }
    }
}
