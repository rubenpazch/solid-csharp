using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.DependencyInversionPrinciple.Good
{
    public interface IMessageType
    {
        void Send(string message);
    }
}
