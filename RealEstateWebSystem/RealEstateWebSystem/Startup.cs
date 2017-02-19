using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RealEstateWebSystem.Startup))]
namespace RealEstateWebSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
