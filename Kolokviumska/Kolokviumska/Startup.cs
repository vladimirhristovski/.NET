using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kolokviumska.Startup))]
namespace Kolokviumska
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
