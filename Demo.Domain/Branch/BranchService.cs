using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Interface.Branch;

namespace Demo.Domain.Branch
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
