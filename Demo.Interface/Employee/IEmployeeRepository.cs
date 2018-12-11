using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface.Employee
{
    public interface IEmployeeRepository
    {
        IEmployee GetEmployee(int employeeId);
        List<IEmployeeSalary> GetEmployeeSalary(int employeeId);
    }
}
