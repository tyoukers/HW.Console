using System;
using System.Collections.Generic;
using System.Text;

namespace HW.API
{
    public class WindowsServiceMessageProvider : IMessageProvider
    {
        /// <summary>
        /// Future implementation could be a WCF service to get a string
        /// </summary>
        /// <returns></returns>
        string IMessageProvider.GetMessage()
        {
            throw new NotImplementedException();
        }
    }
}
