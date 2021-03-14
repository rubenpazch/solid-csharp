using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.DependencyInversionPrinciple.Bad
{
    public class Notification
    {
        private Email _email;
        private Whatsapp _whatsapp;
        private Sms _sms;

        public Notification()
        {
            _email = new Email();
            _whatsapp = new Whatsapp();
            _sms = new Sms();
        }

        public void EmailNotify(string message)
        {            
            _email.Send(message);
        }

        public void WhatsappNotify(string message)
        {
            _whatsapp.Send(message);
        }

        public void SmsNotify(string message)
        {
            _sms.Send(message);
        }
    }
}
