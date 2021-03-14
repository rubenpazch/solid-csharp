using DIP.DependencyInversionPrinciple.Good;
using DIP.DependencyInversionPrinciple.CommonTypes;
using System;


namespace solid_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Notify notifying = new Notify();
            notifying.NotifyMessage("Hola Mundo", EnumMessageType.Email);

        }
    }
}
