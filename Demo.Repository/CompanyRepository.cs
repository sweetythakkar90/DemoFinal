using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Domain.Company;
using Demo.Interface.Company;

namespace Demo.Repository
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
