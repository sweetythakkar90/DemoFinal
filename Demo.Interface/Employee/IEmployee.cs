﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface.Employee
{
    public interface IEmployee
    {
        int EmployeeId { get; set; }
        string FullName { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string Username { get; set; }
        bool Status { get; set; }
        int CompanyId { get; set; }
        int DepartmentId { get; set; }
        int BranchId { get; set; }
        int JobTitleId { get; set; }
        int RoleId { get; set; }
        string HomePhone { get; set; }
        string Mobile { get; set; }
        string UnitNo { get; set; }
        string StreetNo { get; set; }
        string StreetName { get; set; }
        string Suburb { get; set; }
        string PostCode { get; set; }
        string State { get; set; }
        string EmergencyPhone { get; set; }
        string EmergencyRelation { get; set; }
        string Gender { get; set; }
        string BirthDate { get; set; }
    }
}