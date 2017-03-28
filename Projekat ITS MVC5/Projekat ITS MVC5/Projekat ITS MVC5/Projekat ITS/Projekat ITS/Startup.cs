using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Projekat_ITS.Startup))]
namespace Projekat_ITS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
