using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Interface.Employee;

namespace Demo.Domain.Employee
{
    public class EmployeeBonus: IEmployeeBonus
    {
        public int EmployeeId { get; set; }
        public decimal BonusAmount { get; set; }
        public DateTime BonusDate { get; set; }
        public bool Status { get; set; }
        public string BonusRemarks { get; set; }
        public DateTime WhenCreated { get; set; }
        public DateTime WhenChanged { get; set; }
        public int ChangedBy { get; set; }
    }
}
