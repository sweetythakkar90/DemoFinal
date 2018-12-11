using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Interface.Department;

namespace Demo.Domain.Department
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
