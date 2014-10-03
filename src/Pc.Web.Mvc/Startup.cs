using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pc.Web.Mvc.Startup))]
namespace Pc.Web.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
