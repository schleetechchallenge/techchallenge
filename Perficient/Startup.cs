using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Perficient.Startup))]
namespace Perficient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
