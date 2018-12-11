using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Domain.Employee;
using Demo.Interface.Employee;

namespace Demo.Repository
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
                Remarks =  "Inital Salary",
                changed_by = 123,
                when_changed = Convert.ToDateTime("12/08/208"),
                when_created = Convert.ToDateTime("12/08/208")
            });
            return employeeSalary;
        }
    }
}
