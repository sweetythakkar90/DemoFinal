using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Demo.Domain.Branch;
using Demo.Domain.Misc;
using Demo.Interface.Misc;
using Swashbuckle.Swagger.Annotations;

namespace Demo.Controller
{
    public class MiscController : ApiController
    {
        private readonly ILeaveTypesService _leaveTypesService;
        /// <summary>
        /// Misc Controller contractor
        /// </summary>
        /// <param name="leaveTypesService"></param>
        public MiscController(ILeaveTypesService leaveTypesService)
        {
            if(leaveTypesService == null) throw new ArgumentNullException(typeof(ILeaveTypesRepository).Name);
            _leaveTypesService = leaveTypesService;
        }
        /// <summary>
        /// Get LeaveTypes details
        /// </summary>
        /// <param name="leaveTypeId"></param>
        /// <returns></returns>
        [Route("leaveTypes/{leaveTypeId}")]
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK, "Successfully get leaveType", typeof(LeaveTypes))]
        [SwaggerResponse(HttpStatusCode.BadRequest, "Invalid leaveType id")]
        [SwaggerResponse(HttpStatusCode.NotFound, "leaveType not found")]
        public IHttpActionResult Get(int leaveTypeId)
        {
            if (leaveTypeId <= 0) throw new Exception("Invalid leaveType id");

            var result = _leaveTypesService.GetLeaveTypes(leaveTypeId);

            return Ok(result);
        }
    }
}
