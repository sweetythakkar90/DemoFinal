﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface.JobTitle
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
