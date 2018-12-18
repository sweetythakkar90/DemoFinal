using System;
using Hourly.Interface.Branch;

namespace Hourly.Domain.Branch
{
    public class Branch : IBranch
    {
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public string BranchDescription { get; set; }
        public int CompanyId { get; set; }
        public bool Status { get; set; }
        public DateTime WhenCreated { get; set; }
        public DateTime WhenChanged { get; set; }
        public int ChangedBy { get; set; }
    }
}
