using System;
using System.Net;
using System.Web.Http;
using Hourly.Domain.Role;
using Hourly.Interface.Role;
using Swashbuckle.Swagger.Annotations;

namespace Hourly.Controller
{
    public class RoleController: ApiController
    {
        private readonly IRoleService _roleService;
        /// <summary>
        /// Jobtitle Controller contractor
        /// </summary>
        /// <param name="roleService"></param>
        public RoleController(IRoleService roleService)
        {
            if (roleService == null) throw new ArgumentNullException(typeof(IRoleService).Name);
            _roleService = roleService;
        }
        /// <summary>
        /// Get Role details
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        [Route("role/{roleId}")]
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK, "Successfully get role", typeof(Role))]
        [SwaggerResponse(HttpStatusCode.BadRequest, "Invalid role id")]
        [SwaggerResponse(HttpStatusCode.NotFound, "role not found")]
        public IHttpActionResult Get(int roleId)
        {
            if (roleId <= 0) throw new Exception("Invalid role id");

            var result = _roleService.GeRole(roleId);

            return Ok(result);
        }
    }
}
