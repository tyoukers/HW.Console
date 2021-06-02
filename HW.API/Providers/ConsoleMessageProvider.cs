using System;
using System.Collections.Generic;
using System.Text;

namespace HW.API
{
    public class ConsoleMessageProvider : IMessageProvider
    {
        /// <summary>
        /// Return a static string
        /// </summary>
        /// <returns></returns>
        string IMessageProvider.GetMessage()
        {
            return "Hello World";
        }
    }
}
