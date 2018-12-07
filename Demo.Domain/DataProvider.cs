using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Interface;

namespace Demo.Domain
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
