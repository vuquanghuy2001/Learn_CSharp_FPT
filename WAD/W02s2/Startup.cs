using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(W02s2.Startup))]
namespace W02s2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
