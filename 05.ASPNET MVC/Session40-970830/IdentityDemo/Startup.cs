using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdentityDemo.Startup))]
namespace IdentityDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
