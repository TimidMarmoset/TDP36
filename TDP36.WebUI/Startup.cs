using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TDP36.WebUI.Startup))]
namespace TDP36.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
