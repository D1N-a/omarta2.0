using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(omarta_2._0.Startup))]
namespace omarta_2._0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
