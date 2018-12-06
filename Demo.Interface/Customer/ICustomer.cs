using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface.Customer
{
    public interface ICustomer
    {
        int CustomerId { get; set; }
        string FullName { get; set; }
    }
}
