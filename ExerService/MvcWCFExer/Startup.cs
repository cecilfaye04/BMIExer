using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcWCFExer.Startup))]
namespace MvcWCFExer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
