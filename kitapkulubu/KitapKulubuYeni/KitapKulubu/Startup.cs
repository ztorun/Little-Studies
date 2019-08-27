using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KitapKulubu.Startup))]
namespace KitapKulubu
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
