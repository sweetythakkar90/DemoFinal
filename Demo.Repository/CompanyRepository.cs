using Hourly.Domain.Company;
using Hourly.Interface.Company;

namespace Hourly.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        public ICompany GetCompany(int companyId)
        {
            return GetCompanyById(companyId);
        }
        private ICompany GetCompanyById(int companyId)
        {
            var company = new Company();

            company.CompanyId = 123;

            return company;
        }
    }
}
