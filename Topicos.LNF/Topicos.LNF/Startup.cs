using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Topicos.LNF.Startup))]
namespace Topicos.LNF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
