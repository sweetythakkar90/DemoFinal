using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface.Employee
{
    public interface IEmployeeBonus
    {
        int EmployeeId { get; set; }
        decimal BonusAmount { get; set; }
        DateTime BonusDate { get; set; }
        bool Status { get; set; }
        string BonusRemarks { get; set; }
        DateTime WhenCreated { get; set; }
        DateTime WhenChanged { get; set; }
        int ChangedBy { get; set; }
    }
}
