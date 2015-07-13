using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MobileWebApp.Startup))]
namespace MobileWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
