using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AboutMe.Web.Mvc.Startup))]
namespace AboutMe.Web.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
