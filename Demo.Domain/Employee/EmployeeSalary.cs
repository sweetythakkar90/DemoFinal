using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Interface.Employee;

namespace Demo.Domain.Employee
{
    public class EmployeeSalary : IEmployeeSalary
    {
        public int EmployeeId { get; set; }
        public decimal SalaryAmount { get; set; }
        public string SalaryFrequency { get; set; }
        public bool Status { get; set; }
        public DateTime DateApplied { get; set; }
        public string Remarks { get; set; }
        public DateTime when_created { get; set; }
        public DateTime when_changed { get; set; }
        public int changed_by { get; set; }
    }
}
