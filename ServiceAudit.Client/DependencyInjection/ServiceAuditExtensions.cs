using System;

using ServiceAudit.Client;
using ServiceAudit.Client.DependencyInjection;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceAuditExtensions
    {
        /// <summary>
        /// Adds ServiceAudit with default settings.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <returns></returns>
        public static IServiceAuditBuilder AddServiceAudit(this IServiceCollection services)
        {
            var builder = services.AddServiceAuditBuilder();

            // provide default console logging implementation, not suitable for most production scenarios

            return builder;
        }

        /// <summary>
        /// Creates a builder.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <returns></returns>
        public static IServiceAuditBuilder AddServiceAuditBuilder(this IServiceCollection services)
        {
            return new ServiceAuditBuilder(services);
        }

        public static IServiceAuditBuilder AddServiceAudit(this IServiceCollection services, IServiceAuditConfiguration configuration)
        {
            services.Configure<IServiceAuditConfiguration>(configuration);
            return services.AddServiceAudit();
        }

        /// <summary>
        /// Adds ServiceAudit.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <param name="configureAction">The configure action.</param>
        /// <returns></returns>
        public static IServiceAuditBuilder AddServiceAudit(this IServiceCollection services, Action<IServiceAuditConfiguration> configureAction)
        {
            services.Configure(configureAction);
            return services.AddServiceAudit();
        }
    }
}