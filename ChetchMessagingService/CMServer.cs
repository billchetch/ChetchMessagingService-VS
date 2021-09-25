using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Chetch.Utilities.Config;

namespace ChetchMessagingService
{
    public class CMServer : Chetch.Services.TCPMessagingServer 
    {
        public const String VERSION = "1.0";
        public CMServer () : base("ChetchMessagingServer", "ChetchMessagingService", "ChetchMessagingLog")
        {
            Tracing?.TraceEvent(TraceEventType.Information, 0, "Created Chetch Messaging Server version {0}", VERSION);  
        }
    }
}
