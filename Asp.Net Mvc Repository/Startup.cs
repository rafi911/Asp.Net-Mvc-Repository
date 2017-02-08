using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Asp.Net_Mvc_Repository.Startup))]
namespace Asp.Net_Mvc_Repository
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
