using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Toyshop.Startup))]
namespace Toyshop
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
