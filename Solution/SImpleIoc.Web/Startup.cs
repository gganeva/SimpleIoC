using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SImpleIoc.Web.Startup))]
namespace SImpleIoc.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
