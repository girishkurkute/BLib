using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BLib.Startup))]
namespace BLib
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
