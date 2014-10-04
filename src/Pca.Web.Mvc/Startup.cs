using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pca.Web.Mvc.Startup))]
namespace Pca.Web.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
