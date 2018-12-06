using Demo.Interface.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Demo.Controller
{
    public class CustomerController : ApiController
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            if (customerService == null) throw new ArgumentNullException(typeof(ICustomerService).Name);
            _customerService = customerService;
        }
        /// <summary>
        /// Get customer details
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        [Route("customer/{customerId}")]
        [HttpGet]
        public IHttpActionResult Get(int customerId)
        {
            if (customerId <= 0) throw new Exception("Invalid customer id");

            var result = _customerService.GetCustomer(customerId);

            return Ok(result);
        }

        [Route("customers/{id}")]
        [HttpPatch]
        public IHttpActionResult Patch(int id)
        {
            var customer = _customerService.GetCustomer(id);
            try
            {
                if (_customerService.UpdateCustomer(customer))
                {
                    _customerService.UpdateCustomer(customer);
                    return Get(id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return InternalServerError();
        }
    }
}
