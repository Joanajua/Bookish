using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bookish.WebApp.Startup))]
namespace Bookish.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
