using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace ServiceAudit.Client
{
    public class ServiceAuditMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public ServiceAuditMiddleware(RequestDelegate next, ILogger<ServiceAuditMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            _logger.LogDebug($"ServiceAuditMiddleware - Received Request | Endpoint : {context.Request.Path}");

            await _next(context);
        }
    }
}