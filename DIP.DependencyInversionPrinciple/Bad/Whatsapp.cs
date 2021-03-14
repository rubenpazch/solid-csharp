using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.DependencyInversionPrinciple.Bad
{
    public class Whatsapp
    {
        public void Send(string message)
        {
            Console.WriteLine($"comming from Whatsapp {message}");
        }

    }
}
