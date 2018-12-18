using Hourly.Domain;
using Hourly.Interface.Customer;

namespace Hourly.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public ICustomer GetCustomer(int id)
        {
            Customer c = new Customer();

            //call  db query here
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
