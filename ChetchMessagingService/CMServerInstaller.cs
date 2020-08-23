using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chetch.Services;


namespace ChetchMessagingService
{
    [RunInstaller(true)]
    public class CMServerInstaller : ServiceInstaller
    {
        public CMServerInstaller() : base("ChetchMessagingService", 
                                    "Chetch Messaging Service", 
                                    "Runs an instance of the chetch messaging server")
        {
            //empty
        }
    }
}
