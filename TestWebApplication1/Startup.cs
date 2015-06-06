using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestWebApplication1.Startup))]
namespace TestWebApplication1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
