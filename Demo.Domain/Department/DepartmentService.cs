using System;
using Hourly.Interface.Department;

namespace Hourly.Domain.Department
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            if (departmentRepository == null) throw new ArgumentNullException(nameof(departmentRepository));
            _departmentRepository = departmentRepository;
        }

       public IDepartment GetDepartment(int departmentId)
        {
            if (departmentId <= 0)
                throw new Exception("Invalid department id");
            return _departmentRepository.GetDepartment(departmentId);
        }
    }
}
