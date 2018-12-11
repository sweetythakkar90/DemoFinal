using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Interface.JobTitle;

namespace Demo.Domain.JobTitle
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
        public DateTime when_created { get; set; }
        public DateTime when_changed { get; set; }
        public int changed_by { get; set; }
    }
}
