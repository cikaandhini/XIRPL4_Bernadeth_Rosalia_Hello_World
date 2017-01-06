using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(XIRPL4_10_Hello_World.Startup))]
namespace XIRPL4_10_Hello_World
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
