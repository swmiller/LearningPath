using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IntroMvc3.Startup))]
namespace IntroMvc3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
