using ClaimsNotifier.Interfaces;

namespace ClaimsNotifier.Decorators
{
    // Email notification decorator
    public class EmailDecorator(INotifier notifier) : NotifierDecorator(notifier)
    {
        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"[Email] Email sent to customer: 'Your claim \"{message}\" has been received.'");
        }
    }
}
