using Microsoft.Extensions.DependencyInjection;
using System;

namespace ServiceAudit.Client.DependencyInjection
{
    public class ServiceAuditBuilder : IServiceAuditBuilder
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceAuditBuilder"/> class.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <exception cref="System.ArgumentNullException">services</exception>
        public ServiceAuditBuilder(IServiceCollection services)
        {
            Services = services ?? throw new ArgumentNullException(nameof(services));
        }

        /// <summary>
        /// Gets the service collection.
        /// </summary>
        public IServiceCollection Services { get; }
    }
}