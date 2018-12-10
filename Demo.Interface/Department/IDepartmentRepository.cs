using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface.Department
{
    public interface IDepartmentRepository
    {
        IDepartment GetDepartment(int departmentId);
    }
}
