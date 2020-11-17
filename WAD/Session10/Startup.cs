using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Session10.Startup))]
namespace Session10
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
