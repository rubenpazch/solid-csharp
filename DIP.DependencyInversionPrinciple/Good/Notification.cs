using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.DependencyInversionPrinciple.Good
{
    public class Notification
    {
        private IMessageType _messageType;

        public Notification(IMessageType messageType)
        {
            _messageType = messageType;
        }

        public void SendNotificaction(string message)
        {
            _messageType.Send(message);
        }
    }
}
