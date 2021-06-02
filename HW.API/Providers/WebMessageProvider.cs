using System;
using System.Collections.Generic;
using System.Text;

namespace HW.API
{
    public class WebMessageProvider : IMessageProvider
    {
        /// <summary>
        /// Future implementation could be a REST Web API to get a string
        /// </summary>
        /// <returns></returns>
        string IMessageProvider.GetMessage()
        {
            throw new NotImplementedException();
        }
    }
}
