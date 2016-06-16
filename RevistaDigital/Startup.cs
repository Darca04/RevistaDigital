using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RevistaDigital.Startup))]
namespace RevistaDigital
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
