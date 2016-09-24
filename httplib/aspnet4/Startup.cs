using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(aspnet4.Startup))]
namespace aspnet4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
