using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceAudit.Client.DependencyInjection
{
    public static class ServiceAuditApplicationBuilderExtensions
    {
        /// <summary>
        /// Adds Service Audit Middleware to the pipeline.
        /// </summary>
        /// <param name="app">The application.</param>
        public static IApplicationBuilder UseServiceAudit(this IApplicationBuilder app)
        {
            return app;
        }

        internal static void Validate(this IApplicationBuilder app)
        {
            var loggerFactory = app.ApplicationServices.GetService(typeof(ILoggerFactory)) as ILoggerFactory;
            if (loggerFactory == null) throw new ArgumentNullException(nameof(loggerFactory));

            // TODO: GetRequiredService validate DI
        }
    }
}