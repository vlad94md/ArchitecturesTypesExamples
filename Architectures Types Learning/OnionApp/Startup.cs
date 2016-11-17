using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnionApp.Startup))]
namespace OnionApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
