using System;
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
        string Remarks { get; set; }
        DateTime when_created { get; set; }
        DateTime when_changed { get; set; }
        int changed_by { get; set; }
    }
}
