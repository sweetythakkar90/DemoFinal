using System.Collections.Generic;

namespace Hourly.Interface.Employee
{
    public interface IEmployeeRepository
    {
        IEmployee GetEmployee(int employeeId);
        List<IEmployeeSalary> GetEmployeeSalary(int employeeId);
        List<IEmployeeBonus> GetEmployeeBonus(int employeeId);
    }
}
