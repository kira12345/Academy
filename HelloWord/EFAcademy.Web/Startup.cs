using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EFAcademy.Web.Startup))]
namespace EFAcademy.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
