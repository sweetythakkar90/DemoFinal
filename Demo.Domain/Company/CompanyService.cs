using System;
using Hourly.Interface.Company;

namespace Hourly.Domain.Company
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyService(ICompanyRepository companyRepository)
        {
            if (companyRepository == null) throw new ArgumentNullException(nameof(companyRepository));
            _companyRepository = companyRepository;
        }

        public ICompany GetCompany(int companyId)
        {
            if (companyId <= 0)
                throw new Exception("Invalid employee id");
            return _companyRepository.GetCompany(companyId);

        }
    }
}
