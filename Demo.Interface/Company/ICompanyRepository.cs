using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface.Company
{
    public interface ICompanyRepository
    {
        ICompany GetCompany(int companyId);
    }
}
