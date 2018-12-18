using System;
using System.Net;
using System.Web.Http;
using Hourly.Domain;
using Hourly.Interface.Customer;
using Swashbuckle.Swagger.Annotations;

namespace Hourly.Controller
{
    public class CustomerController : ApiController
    {
        private readonly ICustomerService _customerService;
        /// <summary>
        /// Customer Controller contractor
        /// </summary>
        /// <param name="customerService"></param>
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
        [SwaggerResponse(HttpStatusCode.OK, "Successfully get customer", typeof(Customer))]
        [SwaggerResponse(HttpStatusCode.BadRequest, "Invalid customer id")]
        [SwaggerResponse(HttpStatusCode.NotFound, "Customer not found")]
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
