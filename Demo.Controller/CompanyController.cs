using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Demo.Interface.Company;
using System.Net;
using Demo.Domain.Company;
using Swashbuckle.Swagger.Annotations;

namespace Demo.Controller
{
    public class CompanyController : ApiController
    {
        private readonly ICompanyService _companyService;
        /// <summary>
        /// Company Controller contractor
        /// </summary>
        /// <param name="companyService"></param>
        public CompanyController(ICompanyService companyService)
        {
            if (companyService == null) throw new ArgumentNullException(typeof(ICompanyService).Name);
            _companyService = companyService;
        }
        /// <summary>
        /// Get Company details
        /// </summary>
        /// <param name="companyId"></param>
        /// <returns></returns>
        [Route("company/{companyId}")]
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK, "Successfully get company", typeof(Company))]
        [SwaggerResponse(HttpStatusCode.BadRequest, "Invalid company id")]
        [SwaggerResponse(HttpStatusCode.NotFound, "company not found")]
        public IHttpActionResult Get(int companyId)
        {
            if (companyId <= 0) throw new Exception("Invalid employee id");

            var result = _companyService.GetCompany(companyId);

            return Ok(result);
        }
    }
}
