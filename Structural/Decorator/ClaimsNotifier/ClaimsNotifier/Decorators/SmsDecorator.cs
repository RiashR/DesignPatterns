using ClaimsNotifier.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimsNotifier.Decorators
{
    // SMS notification decorator
    public class SmsDecorator(INotifier notifier) : NotifierDecorator(notifier)
    {
        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"[SMS] SMS sent to customer: 'Claim \"{message}\" submitted successfully.'");
        }
    }
}
