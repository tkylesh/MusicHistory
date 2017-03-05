using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MusicHistory.Startup))]
namespace MusicHistory
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
