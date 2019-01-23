using Hourly.WS.API;
using Microsoft.Owin;
using Owin;
using Startup = Hourly.WS.API.App_Start;

[assembly: OwinStartup(typeof(Hourly.WS.API.Startup))]

namespace Hourly.WS.API
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
