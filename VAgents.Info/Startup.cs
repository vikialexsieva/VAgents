using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VAgents.Info.Startup))]
namespace VAgents.Info
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
