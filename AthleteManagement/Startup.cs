using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AthleteManagement.Startup))]
namespace AthleteManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
