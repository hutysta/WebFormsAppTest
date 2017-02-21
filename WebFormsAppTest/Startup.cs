using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFormsAppTest.Startup))]
namespace WebFormsAppTest
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
