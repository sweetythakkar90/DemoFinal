using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Interface.Department;

namespace Demo.Domain.Department
{
    public class Department : IDepartment
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentDescription { get; set; }
        public int BranchId { get; set; }
        public int CompanyId { get; set; }
        public string ColorCode { get; set; }
        public bool Status { get; set; }
    }
}
