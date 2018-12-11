using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Interface.Employee;

namespace Demo.Domain.Employee
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            if(employeeRepository == null) throw new ArgumentNullException(nameof(employeeRepository));
            _employeeRepository = employeeRepository;
        }

        public IEmployee GetEmployee(int employeeId)
        {
            if(employeeId <= 0)
                throw new Exception("Invalid employee id");
            var employee = _employeeRepository.GetEmployee(employeeId);
            employee.EmployeeSalary = GetEmployeeSalary(employeeId);
            employee.EmployeeBonus = GetEmployeeBonus(employeeId);
            return employee;
        }

        private List<IEmployeeBonus> GetEmployeeBonus(int employeeId)
        {
            if (employeeId <= 0) throw new Exception("Invalid employeeId");
            List<IEmployeeBonus> employeeBonus = _employeeRepository.GetEmployeeBonus(employeeId);
            return employeeBonus;
        }

        private List<IEmployeeSalary> GetEmployeeSalary(int employeeId)
        {
            if (employeeId <= 0) throw new Exception("Invalid employeeId");
            List<IEmployeeSalary> employeeSalary = _employeeRepository.GetEmployeeSalary(employeeId);
            return employeeSalary;
        }
    }
}
