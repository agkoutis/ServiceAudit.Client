using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

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
            app.Validate();

            app.UseMiddleware<ServiceAuditMiddleware>();
            return app;
        }

        internal static void Validate(this IApplicationBuilder app)
        {
            var loggerFactory = app.ApplicationServices.GetService(typeof(ILoggerFactory)) as ILoggerFactory;
            if (loggerFactory == null) throw new ArgumentNullException(nameof(loggerFactory));

            var scopeFactory = app.ApplicationServices.GetService<IServiceScopeFactory>();

            using (var scope = scopeFactory.CreateScope())
            {
                var appService = scope.ServiceProvider.GetService<IServiceAuditBuilder>();
            }
        }
    }
}