using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestForOski.Startup))]
namespace TestForOski
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
