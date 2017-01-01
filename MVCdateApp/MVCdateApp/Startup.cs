using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCdateApp.Startup))]
namespace MVCdateApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
