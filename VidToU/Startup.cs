using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidToU.Startup))]
namespace VidToU
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
