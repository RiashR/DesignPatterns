using ClaimsNotifier.Classes;
using ClaimsNotifier.Decorators;
using ClaimsNotifier.Interfaces;

namespace ClaimsNotifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Basic notifier
            INotifier notifier = new ClaimNotifier();

            // Add email functionality
            notifier = new EmailDecorator(notifier);

            // Add SMS functionality
            notifier = new SmsDecorator(notifier);

            // Submit a claim
            notifier.Send("Car accident claim #C12345");

            Console.ReadLine();
        }
    }
}
