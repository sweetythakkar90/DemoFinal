﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface.Employee
{
    public interface IEmployeeSalary
    {
        int EmployeeId { get; set; }
        decimal SalaryAmount { get; set; }
        string SalaryFrequency { get; set; }
        bool Status { get; set; }
        DateTime DateApplied { get; set; }
        string SalaryRemarks { get; set; }
        DateTime WhenCreated { get; set; }
        DateTime WhenChanged { get; set; }
        int ChangedBy { get; set; }
    }
}
