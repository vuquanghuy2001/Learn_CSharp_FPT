using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(U03.Startup))]
namespace U03
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
