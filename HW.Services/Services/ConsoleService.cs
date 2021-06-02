using System;

namespace HW.Services
{
    public class ConsoleService : IMessageWriterService
    {
        void IMessageWriterService.Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
