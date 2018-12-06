using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface.Customer
{
    public interface ICustomerRepository
    {
        ICustomer GetCustomer(int id);
        bool UpdateCustomer(ICustomer enterpriseCustomer);
    }
}
