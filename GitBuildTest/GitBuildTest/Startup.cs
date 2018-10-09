using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitBuildTest.Startup))]
namespace GitBuildTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
