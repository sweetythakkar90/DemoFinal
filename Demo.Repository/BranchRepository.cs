using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Domain.Branch;
using Demo.Interface.Branch;

namespace Demo.Repository
{
    public class BranchRepository : IBranchRepository
    {
        public IBranch GetBranch(int branchId)
        {
            return getBranchById(branchId);
        }

        private IBranch getBranchById(int branchId)
        {
            IBranch branch = new Branch();
            branch.BranchId =  123;
            return branch;
        }
    }
}
