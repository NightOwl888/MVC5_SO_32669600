using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5_SO_32669600.Startup))]
namespace MVC5_SO_32669600
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
