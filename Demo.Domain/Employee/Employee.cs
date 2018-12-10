using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Interface.Employee;

namespace Demo.Domain.Employee
{
    public class Employee : IEmployee
    {
        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public bool Status { get; set; }
        public int CompanyId { get; set; }
        public int DepartmentId { get; set; }
        public int BranchId { get; set; }
        public int JobTitleId { get; set; }
        public int RoleId { get; set; }
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
    }
}
