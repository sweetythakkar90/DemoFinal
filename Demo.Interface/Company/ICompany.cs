using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface.Company
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
        DateTime when_created { get; set; }
        DateTime when_changed { get; set; }
        int changed_by { get; set; }

    }
}
