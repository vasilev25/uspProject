using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(uspProject.Startup))]
namespace uspProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
