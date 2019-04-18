using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ISPIT.Startup))]
namespace ISPIT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
