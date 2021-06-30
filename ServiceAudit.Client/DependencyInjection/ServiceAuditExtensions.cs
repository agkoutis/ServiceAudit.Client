using System;

using Microsoft.Extensions.Configuration;

using ServiceAudit.Client;
using ServiceAudit.Client.DependencyInjection;
using ServiceAudit.Common;
using ServiceAudit.Common.Interfaces;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceAuditExtensions
    {
        /// <summary>
        /// Adds ServiceAudit with default settings.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <returns></returns>
        //public static IServiceAuditBuilder AddServiceAudit(this IServiceCollection services)
        //{
        //    var builder = services.AddServiceAudit(Options =>
        //    {
        //    });

        //    // provide default console logging implementation, not suitable for most production scenarios

        //    return builder;
        //}

        public static IServiceAuditBuilder AddServiceAudit(this IServiceCollection services, Action<IServiceAuditConfiguration> action)
        {
            services.Configure(action);
            services.AddSingleton<IServiceAuditConfiguration>();
            return services.AddServiceAudit();
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

        public static IServiceAuditBuilder AddServiceAudit(this IServiceCollection services)
        {
            var builder = services.AddServiceAuditBuilder();
            return builder;
        }

        ///// <summary>
        ///// Adds ServiceAudit.
        ///// </summary>
        ///// <param name="services">The services.</param>
        ///// <param name="configureAction">The configure action.</param>
        ///// <returns></returns>
        //public static IServiceAuditBuilder AddServiceAudit(this IServiceCollection services, IServiceAuditConfiguration configureAction)
        //{
        //    services.Configure(configureAction);
        //    return services.AddServiceAudit();
        //}
    }
}