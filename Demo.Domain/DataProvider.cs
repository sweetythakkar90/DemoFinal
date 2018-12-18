using System.Configuration;
using Hourly.Interface;

namespace Hourly.Domain
{
    public class DataProvider : Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
            Bind<IDbConnectionFactory>()
                .To<SqlConnectionFactory>()
                .WithConstructorArgument("connectionString",
                    ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString);
        }
    }
}
