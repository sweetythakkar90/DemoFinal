using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using System.Net.Http.Formatting;
using System.Web.Http.Dispatcher;
using System.Reflection;
using System.IO;
using Unity;
using Demo.Interface.Customer;
using Unity.Lifetime;
using Demo.Repository;
using Demo.Domain;
using Demo.Domain.Branch;
using Demo.Domain.Company;
using Demo.Domain.Department;
using Demo.Domain.Employee;
using Demo.Domain.JobTitle;
using Demo.Domain.Misc;
using Demo.Domain.Role;
using Demo.Interface.Branch;
using Demo.Interface.Company;
using Demo.Interface.Department;
using Demo.Interface.Employee;
using Demo.Interface.JobTitle;
using Demo.Interface.Misc;
using Demo.Interface.Role;

namespace Demo.WS.API
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
