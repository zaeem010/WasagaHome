using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WasagaHome.Startup))]
namespace WasagaHome
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
