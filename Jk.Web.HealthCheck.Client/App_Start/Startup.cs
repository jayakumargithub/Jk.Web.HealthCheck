using Jk.Web.HealthCheck.Client;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Startup))]
namespace Jk.Web.HealthCheck.Client
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Use<HealthCheckMiddleware>();
        }
    }
}