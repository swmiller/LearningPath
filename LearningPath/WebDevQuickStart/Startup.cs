using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebDevQuickStart.Startup))]
namespace WebDevQuickStart
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
