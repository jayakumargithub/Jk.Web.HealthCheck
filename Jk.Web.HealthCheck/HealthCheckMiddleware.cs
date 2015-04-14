using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin;

namespace Jk.Web.HealthCheck
{
    public class HealthCheckMiddleware : OwinMiddleware
    {
        public HealthCheckMiddleware(OwinMiddleware next) : base(next)
        {
        }

        public override Task Invoke(IOwinContext context)
        {
            return context.Request.Path.StartsWithSegments(new PathString("/HealthCheck"))
                ? context.Response.WriteAsync(AppVersion.ThisApplicationVersion.ToString())
                : Next.Invoke(context);
        }
    }
}
