using System;
using Hourly.Interface.Branch;

namespace Hourly.Domain.Branch
{
    public class BranchService : IBranchService
    {
        private readonly IBranchRepository _branchRepository;

        public BranchService(IBranchRepository branchRepository)
        {
            if (branchRepository == null) throw new ArgumentNullException(nameof(branchRepository));
            _branchRepository = branchRepository;
        }

        public IBranch GetBranch(int branchId)
        {
            if (branchId <= 0)
                throw new Exception("Invalid branch id");
            return _branchRepository.GetBranch(branchId);
        }
    }
}
