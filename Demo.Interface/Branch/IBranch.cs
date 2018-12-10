using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface.Branch
{
    public interface IBranch
    {
        int BranchId { get; set; }
        string BranchName { get; set; }
        string BranchDescription { get; set; }
        int CompanyId { get; set; }
        bool Status { get; set; }
        DateTime when_created { get; set; }
        DateTime when_changed { get; set; }
        int changed_by { get; set; }

    }
}
