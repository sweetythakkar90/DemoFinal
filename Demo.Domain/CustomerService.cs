﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Interface.Customer;

namespace Demo.Domain
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(
            ICustomerRepository customerRepository)
        {
            if (customerRepository == null) throw new ArgumentNullException(nameof(customerRepository));
           
            _customerRepository = customerRepository;
            
        }
        public ICustomer GetCustomer(int id)
        {
            if (id <= 0) throw new Exception("Invalid customer id");
            return  _customerRepository.GetCustomer(id);
           
        }
        public bool UpdateCustomer(ICustomer enterpriseCustomer)
        {
            return _customerRepository.UpdateCustomer(enterpriseCustomer);
        }
    }
}
