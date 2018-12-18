using System;

namespace Hourly.Interface.Branch
{
    public interface IBranch
    {
        int BranchId { get; set; }
        string BranchName { get; set; }
        string BranchDescription { get; set; }
        int CompanyId { get; set; }
        bool Status { get; set; }
        DateTime WhenCreated { get; set; }
        DateTime WhenChanged { get; set; }
        int ChangedBy { get; set; }

    }
}
