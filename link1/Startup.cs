using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(link1.Startup))]
namespace link1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
