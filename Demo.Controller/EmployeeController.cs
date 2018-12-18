using System;
using System.Net;
using System.Web.Http;
using Hourly.Domain.Employee;
using Hourly.Interface.Employee;
using Swashbuckle.Swagger.Annotations;

namespace Hourly.Controller
{
    public class EmployeeController : ApiController
    {
        private readonly IEmployeeService _employeeService;
        /// <summary>
        /// Employee Controller contractor
        /// </summary>
        /// <param name="employeeService"></param>
        public EmployeeController(IEmployeeService employeeService)
        {
            if (employeeService == null) throw new ArgumentNullException(typeof(IEmployeeService).Name);
            _employeeService = employeeService;
        }
        /// <summary>
        /// Get Employee details
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        [Route("employee/{employeeId}")]
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK, "Successfully get employee", typeof(Employee))]
        [SwaggerResponse(HttpStatusCode.BadRequest, "Invalid employee id")]
        [SwaggerResponse(HttpStatusCode.NotFound, "employee not found")]
        public IHttpActionResult Get(int employeeId)
        {
            if (employeeId <= 0) throw new Exception("Invalid employee id");

            var result = _employeeService.GetEmployee(employeeId);

            return Ok(result);
        }
    }
}
