using Microsoft.Owin;
using Owin;


[assembly: OwinStartupAttribute(typeof(CovidCreative.Startup))]
namespace CovidCreative
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
