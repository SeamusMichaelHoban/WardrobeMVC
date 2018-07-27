using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WardrobeMVCV1.Startup))]
namespace WardrobeMVCV1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
