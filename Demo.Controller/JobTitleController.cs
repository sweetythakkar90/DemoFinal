using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Demo.Interface.JobTitle;
using System.Net;
using Demo.Domain.Department;
using Swashbuckle.Swagger.Annotations;

namespace Demo.Controller
{
    public class JobTitleController : ApiController
    {
        private readonly IJobTitleService _jobTitleService;
        /// <summary>
        /// Jobtitle Controller contractor
        /// </summary>
        /// <param name="jobTitleService"></param>
        public JobTitleController(IJobTitleService jobTitleService)
        {
            if (jobTitleService == null) throw new ArgumentNullException(typeof(IJobTitleService).Name);
            _jobTitleService = jobTitleService;
        }
        /// <summary>
        /// Get JobTitle details
        /// </summary>
        /// <param name="jobTitleId"></param>
        /// <returns></returns>
        [Route("jobTitle/{jobTitleId}")]
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK, "Successfully get jobTitle", typeof(Department))]
        [SwaggerResponse(HttpStatusCode.BadRequest, "Invalid jobTitle id")]
        [SwaggerResponse(HttpStatusCode.NotFound, "jobTitle not found")]
        public IHttpActionResult Get(int jobTitleId)
        {
            if (jobTitleId <= 0) throw new Exception("Invalid department id");

            var result = _jobTitleService.GeJobTitle(jobTitleId);

            return Ok(result);
        }
    }
}
