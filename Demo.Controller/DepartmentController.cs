using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Demo.Interface.Department;
using System.Net;
using Demo.Domain.Department;
using Swashbuckle.Swagger.Annotations;

namespace Demo.Controller
{
    public class DepartmentController : ApiController
    {
        private readonly IDepartmentService _departmentService;
        /// <summary>
        /// Departmenr Controller contractor
        /// </summary>
        /// <param name="departmentService"></param>
        public DepartmentController(IDepartmentService departmentService)
        {
            if (departmentService == null) throw new ArgumentNullException(typeof(IDepartmentService).Name);
            _departmentService = departmentService;
        }
        /// <summary>
        /// Get Department details
        /// </summary>
        /// <param name="departmentId"></param>
        /// <returns></returns>
        [Route("department/{departmentId}")]
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK, "Successfully get department", typeof(Department))]
        [SwaggerResponse(HttpStatusCode.BadRequest, "Invalid department id")]
        [SwaggerResponse(HttpStatusCode.NotFound, "department not found")]
        public IHttpActionResult Get(int departmentId)
        {
            if (departmentId <= 0) throw new Exception("Invalid department id");

            var result = _departmentService.GetDepartment(departmentId);

            return Ok(result);
        }
    }
}
