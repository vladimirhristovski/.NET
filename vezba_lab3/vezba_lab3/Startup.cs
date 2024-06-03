using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(vezba_lab3.Startup))]
namespace vezba_lab3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
