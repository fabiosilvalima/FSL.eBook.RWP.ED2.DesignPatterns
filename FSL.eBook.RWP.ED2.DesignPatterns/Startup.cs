using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(FSL.eBook.RWP.ED2.DesignPatterns.Startup))]
namespace FSL.eBook.RWP.ED2.DesignPatterns
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
