using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Demo.Interface.Employee;
using System.Net;
using Swashbuckle.Swagger.Annotations;
using Demo.Domain.Employee;

namespace Demo.Controller
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
