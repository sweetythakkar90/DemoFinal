using Hourly.Domain.Branch;
using Hourly.Interface.Branch;

namespace Hourly.Repository
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
