using Demo.Interface.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Domain
{
    public class Customer : ICustomer
    {
        public int CustomerId { get; set; }
        public string FullName { get; set; }
    }
}
