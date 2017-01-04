using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmartHome.WEB.Startup))]
namespace SmartHome.WEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
