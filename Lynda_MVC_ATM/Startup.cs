using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lynda_MVC_ATM.Startup))]
namespace Lynda_MVC_ATM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
