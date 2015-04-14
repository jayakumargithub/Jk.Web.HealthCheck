using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using eSpares.Levity;

namespace Jk.Web.HealthCheck
{
    public static class AppVersion
    {
        private static readonly string ApplicationVersion = ApplicationAssemblyUtility.GetApplicationVersionNumber();

        public static string ThisApplicationVersion
        {
            get { return ApplicationVersion; }
        }
    }
}
