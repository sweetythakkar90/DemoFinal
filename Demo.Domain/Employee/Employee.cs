using System;
using System.Collections.Generic;
using Hourly.Interface.Employee;

namespace Hourly.Domain.Employee
{
    public class Employee : IEmployee
    {
        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }
        public int CompanyId { get; set; }
        public int DepartmentId { get; set; }
        public int BranchId { get; set; }
        public int JobTitleId { get; set; }
        public int RoleId { get; set; }
        public DateTime JoiningDate { get; set; }
        public DateTime? TerminationDate { get; set; }
        public string HomePhone { get; set; }
        public string Mobile { get; set; }
        public string UnitNo { get; set; }
        public string StreetNo { get; set; }
        public string StreetName { get; set; }
        public string Suburb { get; set; }
        public string PostCode { get; set; }
        public string State { get; set; }
        public string EmergencyPhone { get; set; }
        public string EmergencyRelation { get; set; }
        public string Gender { get; set; }
        public string BirthDate { get; set; }
        public DateTime WhenCreated { get; set; }
        public DateTime WhenChanged { get; set; }
        public int ChangedBy { get; set; }
        public List<IEmployeeSalary> EmployeeSalary { get; set; }
        public List<IEmployeeBonus> EmployeeBonus { get; set; }
    }
}
