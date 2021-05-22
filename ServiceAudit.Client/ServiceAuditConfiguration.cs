using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;

using ServiceAudit.Common;

namespace ServiceAudit.Client
{
    public class ServiceAuditConfiguration
    {
        public ServiceAuditLoggerType ServiceAudit { get; set; }

        public string ServiceName { get; set; }
    }
}