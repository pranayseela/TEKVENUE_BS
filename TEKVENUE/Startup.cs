using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TEKVENUE.Startup))]
namespace TEKVENUE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
