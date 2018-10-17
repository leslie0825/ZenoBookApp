using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZenoBookApp.Startup))]
namespace ZenoBookApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
