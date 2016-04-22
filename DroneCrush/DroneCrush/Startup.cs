using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DroneCrush.Startup))]
namespace DroneCrush
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
