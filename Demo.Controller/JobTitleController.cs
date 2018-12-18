using System;
using System.Net;
using System.Web.Http;
using Hourly.Domain.Department;
using Hourly.Interface.JobTitle;
using Swashbuckle.Swagger.Annotations;

namespace Hourly.Controller
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
