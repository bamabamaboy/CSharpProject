using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AuthProject.Startup))]
namespace AuthProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
