using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jobquilibrium.Startup))]
namespace jobquilibrium
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
