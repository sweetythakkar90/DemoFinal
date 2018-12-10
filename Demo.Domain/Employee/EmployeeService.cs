﻿using System;
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

        public IEmployee GetEmployee(int id)
        {
            if(id <= 0)
                throw new Exception("Invalid employee id");
            return _employeeRepository.GetEmployee(id);

        }
    }
}