using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Prufa3.Startup))]
namespace Prufa3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
