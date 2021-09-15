using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Prg522_7864.Startup))]
namespace Prg522_7864
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
