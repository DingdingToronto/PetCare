using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PetCare.Startup))]
namespace PetCare
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
