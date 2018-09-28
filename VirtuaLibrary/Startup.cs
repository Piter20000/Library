using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VirtuaLibrary.Startup))]
namespace VirtuaLibrary
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
