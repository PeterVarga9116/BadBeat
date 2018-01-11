using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BadBeat.Web.Startup))]
namespace BadBeat.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
