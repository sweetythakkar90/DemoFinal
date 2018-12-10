using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Interface.Branch;

namespace Demo.Domain.Branch
{
    public class Branch : IBranch
    {
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public string BranchDescription { get; set; }
        public int CompanyId { get; set; }
        public bool Status { get; set; }

    }
}
