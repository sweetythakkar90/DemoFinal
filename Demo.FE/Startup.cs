using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Demo.FE.Startup))]
namespace Demo.FE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
