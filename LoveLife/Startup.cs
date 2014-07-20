using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LoveLife.Startup))]
namespace LoveLife
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
