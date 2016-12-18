using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SICD.Startup))]
namespace SICD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
