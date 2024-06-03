using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IT_lab3.Startup))]
namespace IT_lab3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
