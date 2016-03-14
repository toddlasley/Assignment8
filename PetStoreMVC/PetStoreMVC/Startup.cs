using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PetStoreMVC.Startup))]
namespace PetStoreMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
