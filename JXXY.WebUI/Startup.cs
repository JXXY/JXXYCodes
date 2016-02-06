using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JXXY.WebUI.Startup))]
namespace JXXY.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
