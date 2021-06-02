using System;
using System.Collections.Generic;
using System.Text;

namespace HW.Services
{
    public class DatabaseService : IMessageWriterService
    {
        void IMessageWriterService.Write(string message)
        {
            throw new NotImplementedException();
        }
    }
}
