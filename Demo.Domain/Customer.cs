using Hourly.Interface.Customer;

namespace Hourly.Domain
{
    public class Customer : ICustomer
    {
        public int CustomerId { get; set; }
        public string FullName { get; set; }
    }
}
