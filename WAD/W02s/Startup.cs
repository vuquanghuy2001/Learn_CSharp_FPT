using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(W02s.Startup))]
namespace W02s
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
