using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspTest.Startup))]
namespace AspTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
