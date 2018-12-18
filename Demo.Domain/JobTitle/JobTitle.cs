using System;
using Hourly.Interface.JobTitle;

namespace Hourly.Domain.JobTitle
{
    public class JobTitle : IJobTitle
    {
        public int JobTitleId { get; set; }
        public string JobTitleName { get; set; }
        public string JobTitleDesc { get; set; }
        public int DepartmentId { get; set; }
        public int BranchId { get; set; }
        public int CompanyId { get; set; }
        public bool Status { get; set; }
        public DateTime WhenCreated { get; set; }
        public DateTime WhenChanged { get; set; }
        public int ChangedBy { get; set; }
    }
}
