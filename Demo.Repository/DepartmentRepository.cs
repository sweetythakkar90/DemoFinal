using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Domain.Department;
using Demo.Interface.Department;

namespace Demo.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        public IDepartment GetDepartment(int departmentId)
        {
            return GetDepartmentById(departmentId);
        }

        private IDepartment GetDepartmentById(int departmentId)
        {
            IDepartment department = new Department();
            department.DepartmentId = 123;
            return department;
        }
    }
}
