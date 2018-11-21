using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JobSystem.Startup))]
namespace JobSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
