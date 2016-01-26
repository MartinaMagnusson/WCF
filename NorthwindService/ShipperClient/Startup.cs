using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShipperClient.Startup))]
namespace ShipperClient
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
