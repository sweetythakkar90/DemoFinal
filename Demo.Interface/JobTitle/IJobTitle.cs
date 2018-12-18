using System;

namespace Hourly.Interface.JobTitle
{
    public interface IJobTitle
    {
        int JobTitleId { get; set; }
        string JobTitleName { get; set; }
        string JobTitleDesc { get; set; }
        int DepartmentId { get; set; }
        int BranchId { get; set; }
        int CompanyId { get; set; }
        bool Status { get; set; }
        DateTime WhenCreated { get; set; }
        DateTime WhenChanged { get; set; }
        int ChangedBy { get; set; }
    }
}
