using HW.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW.Console
{
    public class ProviderLocator
    {
        public IMessageProvider LocateMessageProvider(string messageProvider)
        {
            // console is all that's implemented
            return messageProvider.ToLower() switch
            {
                "console" => new ConsoleMessageProvider(),
                "mobile" => new MobileMessageProvider(),
                "web" => new WebMessageProvider(),
                "windowsservice" => new WindowsServiceMessageProvider(),
                _ => new ConsoleMessageProvider()
            };
        }
    }
}
