using System;
using System.Collections.Generic;
using Hourly.Domain.Employee;
using Hourly.Interface.Employee;

namespace Hourly.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public IEmployee GetEmployee(int employeeId)
        {
            return GetEmployeeById(employeeId);
        }
        private IEmployee GetEmployeeById(int employeeId)
        {
            var employee = new Employee();

            //ADD DB CONNECTION LOGIC HERE

            //var sql = @"SELECT PRODUCT_ID, PRODUCT_CODE, PRODUCT_NAME, NETWORK, TYPE, SUB_TYPE, SERVICE_TYPE_ID, CUSTOMER_TYPE_ID, SUPPLIER_ID, SERVICE_SUB_TYPE_ID, IS_ACTIVE
            //            FROM EMPLOYEE
            //            WHERE EMPLOYEE_ID=:employeeId AND STATUS=:active ";
            //using (var cmd = Oh.da.NewDbCommand(sql))
            //{
            //    Oh.da.BindParameterToDbCommand(cmd, "customerTypeId", customerTypeId);
            //    Oh.da.BindParameterToDbCommand(cmd, "active", Active);
            //    using (var dr = Oh.GetDataReader(cmd))
            //    {
            //        while (dr.Read())
            //        {
            //            employee.EmployeeId = dr.GetInt32("PRODUCT_ID");
            //            employee.Status = dr.GetBoolean("IS_ACTIVE");
            //        }
            //    }
            //}

            employee.EmployeeId = 123;
            return employee;
        }

        public List<IEmployeeSalary> GetEmployeeSalary(int employeeId)
        {
            if (employeeId <= 0) throw new Exception("Invalid employeeId");
            var employeeSalary = new List<IEmployeeSalary>();
            employeeSalary.Add(new EmployeeSalary()
            {
                EmployeeId = 123,
                SalaryAmount = 75000,
                SalaryFrequency = "Annual",
                Status = true,
                DateApplied = Convert.ToDateTime("12/08/208"),
                SalaryRemarks =  "Inital Salary",
                ChangedBy = 123,
                WhenChanged = Convert.ToDateTime("12/08/208"),
                WhenCreated = Convert.ToDateTime("12/08/208")
            });
            return employeeSalary;
        }
        public List<IEmployeeBonus> GetEmployeeBonus(int employeeId)
        {
            if (employeeId <= 0) throw new Exception("Invalid employeeId");
            var employeeBonus = new List<IEmployeeBonus>();
            employeeBonus.Add(new EmployeeBonus()
            {
                EmployeeId = 123,
                BonusAmount = 1250,
                Status = true,
                BonusDate = Convert.ToDateTime("12/08/208"),
                BonusRemarks = "Extra Work",
                ChangedBy = 123,
                WhenChanged = Convert.ToDateTime("12/08/208"),
                WhenCreated = Convert.ToDateTime("12/08/208")
            });
            return employeeBonus;
        }
    }
}
