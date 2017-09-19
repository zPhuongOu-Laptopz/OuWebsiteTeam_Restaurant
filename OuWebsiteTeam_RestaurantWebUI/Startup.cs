using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OuWebsiteTeam_RestaurantWebUI.Startup))]
namespace OuWebsiteTeam_RestaurantWebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
