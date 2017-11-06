using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(rest_rater.Startup))]
namespace rest_rater
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
