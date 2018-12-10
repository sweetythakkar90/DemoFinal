using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface.Branch
{
    public interface IBranchService
    {
        IBranch GetBranch(int branchId);
    }
}
