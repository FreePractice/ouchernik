using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ouchernik.Web.Startup))]
namespace ouchernik.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
