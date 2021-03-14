using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.DependencyInversionPrinciple.Good
{
    public class Sms : IMessageType
    {
        public void Send(string message)
        {
            Console.WriteLine($"commig from SMS {message}");
        }
    }
}
