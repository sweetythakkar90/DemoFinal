using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface.Role
{
    public interface IRoleService
    {
        IRole GeRole(int roleId);
    }
}
