using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(W03.Startup))]
namespace W03
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
