using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IT_aud_db_kol2.Startup))]
namespace IT_aud_db_kol2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
