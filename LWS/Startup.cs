using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LWS.Startup))]
namespace LWS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
