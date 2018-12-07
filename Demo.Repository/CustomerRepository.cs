using Demo.Domain;
using Demo.Interface.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public ICustomer GetCustomer(int id)
        {
            Customer c = new Customer();
            c.CustomerId = 123;
            c.FullName = "Test";
            return c;
        }

        public bool UpdateCustomer(ICustomer customer)
        {
            return true;
        }
    }
    }
