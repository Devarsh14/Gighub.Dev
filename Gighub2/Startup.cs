using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gighub2.Startup))]
namespace Gighub2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
