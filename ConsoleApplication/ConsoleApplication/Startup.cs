using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConsoleApplication.Startup))]
namespace ConsoleApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
