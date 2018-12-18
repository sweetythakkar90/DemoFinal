using System;
using Hourly.Interface.Company;

namespace Hourly.Domain.Company
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
        public DateTime WhenCreated { get; set; }
        public DateTime WhenChanged { get; set; }
        public int ChangedBy { get; set; }
    }
}
