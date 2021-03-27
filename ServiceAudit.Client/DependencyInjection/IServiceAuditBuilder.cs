namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// ServiceAuditBuilder builder Interface
    /// </summary>
   public interface IServiceAuditBuilder
    {
        /// <summary>
        /// Gets the services.
        /// </summary>
        /// <value>
        /// The services.
        /// </value>
        IServiceCollection Services { get; }
    }
}
