using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewApp.Startup))]
namespace NewApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
