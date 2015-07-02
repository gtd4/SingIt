using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SingIt.Startup))]
namespace SingIt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
