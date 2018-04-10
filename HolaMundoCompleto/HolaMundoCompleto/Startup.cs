using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HolaMundoCompleto.Startup))]
namespace HolaMundoCompleto
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
