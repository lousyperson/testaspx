using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testaspx.Startup))]
namespace testaspx
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
