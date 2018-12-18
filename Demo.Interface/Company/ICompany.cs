using System;

namespace Hourly.Interface.Company
{
    public interface ICompany
    {
        int CompanyId { get; set; }
        string CompanyName { get; set; }
        string ABN { get; set; }
        string ACN { get; set; }
        string Email { get; set; }
        string Phone { get; set; }
        string WebsiteUrl { get; set; }
        string UnitNo { get; set; }
        string StreetNo { get; set; }
        string StreetName { get; set; }
        string Suburb { get; set; }
        string Postcode { get; set; }
        string State { get; set; }
        string Status { get; set; }
        DateTime WhenCreated { get; set; }
        DateTime WhenChanged { get; set; }
        int ChangedBy { get; set; }

    }
}
