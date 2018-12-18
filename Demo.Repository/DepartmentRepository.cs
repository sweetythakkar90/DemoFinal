using Hourly.Domain.Department;
using Hourly.Interface.Department;

namespace Hourly.Repository
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
