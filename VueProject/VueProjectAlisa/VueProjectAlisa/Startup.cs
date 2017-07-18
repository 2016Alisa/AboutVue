using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VueProjectAlisa.Startup))]
namespace VueProjectAlisa
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
