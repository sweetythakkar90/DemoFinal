using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Interface.Company;

namespace Demo.Domain.Company
{
    public class Company : ICompany
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string ABN { get; set; }
        public string ACN { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string WebsiteUrl { get; set; }
        public string UnitNo { get; set; }
        public string StreetNo { get; set; }
        public string StreetName { get; set; }
        public string Suburb { get; set; }
        public string Postcode { get; set; }
        public string State { get; set; }
        public string Status { get; set; }
        public DateTime when_created { get; set; }
        public DateTime when_changed { get; set; }
        public int changed_by { get; set; }
    }
}
