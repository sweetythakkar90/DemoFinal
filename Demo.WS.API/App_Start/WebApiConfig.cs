using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;
using Hourly.Domain;
using Hourly.Domain.Branch;
using Hourly.Domain.Company;
using Hourly.Domain.Department;
using Hourly.Domain.Employee;
using Hourly.Domain.JobTitle;
using Hourly.Domain.Misc;
using Hourly.Domain.Role;
using Hourly.Interface.Branch;
using Hourly.Interface.Company;
using Hourly.Interface.Customer;
using Hourly.Interface.Department;
using Hourly.Interface.Employee;
using Hourly.Interface.JobTitle;
using Hourly.Interface.Misc;
using Hourly.Interface.Role;
using Hourly.Repository;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using Unity;
using Unity.Lifetime;

namespace Hourly.WS.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            InitializeServices(config);
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            
           
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.SuppressHostPrincipal();
            var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
            jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }

        private static void InitializeServices(HttpConfiguration config)
        {
            var container = new UnityContainer();
            container.RegisterType<ICustomerRepository, CustomerRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<ICustomerService, CustomerService>(new HierarchicalLifetimeManager());
            container.RegisterType<ICompanyRepository, CompanyRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<ICompanyService, CompanyService>(new HierarchicalLifetimeManager());
            container.RegisterType<IEmployeeRepository, EmployeeRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IEmployeeService, EmployeeService>(new HierarchicalLifetimeManager());
            container.RegisterType<IDepartmentRepository, DepartmentRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IDepartmentService, DepartmentService>(new HierarchicalLifetimeManager());

            container.RegisterType<IBranchRepository, BranchRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IBranchService, BranchService>(new HierarchicalLifetimeManager());

            container.RegisterType<IRoleRepository, RoleRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IRoleService, RoleService>(new HierarchicalLifetimeManager());

            container.RegisterType<IJobTitleRepository, JobTitleRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IJobTitleService, JobTitleService>(new HierarchicalLifetimeManager());

            container.RegisterType<ILeaveTypesRepository, LeaveTypesRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<ILeaveTypesService, LeaveTypesService>(new HierarchicalLifetimeManager());

           
            config.DependencyResolver = new UnityResolver(container);
        }
    }
}
