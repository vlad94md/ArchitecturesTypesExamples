using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CleanArchitecture.UI.Startup))]
namespace CleanArchitecture.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
