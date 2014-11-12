using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VeterinariaMVC.Startup))]
namespace VeterinariaMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
