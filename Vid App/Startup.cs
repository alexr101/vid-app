using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vid_App.Startup))]
namespace Vid_App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}