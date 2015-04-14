using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin;

namespace Jk.Web.HealthCheck
{
    public interface IHealthCheckInspector
    {
        Task CheckHealth(IOwinContext context);
    }
}
