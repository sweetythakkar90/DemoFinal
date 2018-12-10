using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Demo.Domain.Branch;
using Demo.Interface.Branch;
using System.Net;
using Swashbuckle.Swagger.Annotations;

namespace Demo.Controller
{
    public class BranchController : ApiController
    {
        private readonly IBranchService _branchService;
        /// <summary>
        /// Branch Controller contractor
        /// </summary>
        /// <param name="branchService"></param>
        public BranchController(IBranchService branchService)
        {
            if (branchService == null) throw new ArgumentNullException(typeof(IBranchService).Name);
            _branchService = branchService;
        }
        /// <summary>
        /// Get Branch details
        /// </summary>
        /// <param name="branchId"></param>
        /// <returns></returns>
        [Route("branch/{branchId}")]
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK, "Successfully get branch", typeof(Branch))]
        [SwaggerResponse(HttpStatusCode.BadRequest, "Invalid branch id")]
        [SwaggerResponse(HttpStatusCode.NotFound, "branch not found")]
        public IHttpActionResult Get(int branchId)
        {
            if (branchId <= 0) throw new Exception("Invalid branch id");

            var result = _branchService.GetBranch(branchId);

            return Ok(result);
        }
    }
}
