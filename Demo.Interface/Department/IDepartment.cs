using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface.Department
{
    public interface IDepartment
    {
        int DepartmentId { get; set; }
        string DepartmentName { get; set; }
        string DepartmentDescription { get; set; }
        int BranchId { get; set; }
        int CompanyId { get; set; }
        string ColorCode { get; set; }
        bool Status { get; set; }
    }
}
