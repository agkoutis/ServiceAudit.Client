using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceAudit.Client.Handlers
{
    /// <summary>
    /// Endpoint handler
    /// </summary>
    internal interface IEndpointHandler
    {
        /// <summary>
        /// Processes the request and validates whitelist.
        /// </summary>
        /// <param name="context">The HTTP context.</param>
        /// <returns></returns>

        Task<bool> ProcessAsync(HttpContext context);
    }
}