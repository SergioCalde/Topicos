using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(topicos.Startup))]
namespace topicos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
