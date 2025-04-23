using ClaimsNotifier.Interfaces;

namespace ClaimsNotifier.Decorators
{
    // Base decorator class
    public abstract class NotifierDecorator : INotifier
    {
        protected INotifier _notifier;

        protected NotifierDecorator(INotifier notifier)
        {
            _notifier = notifier;
        }

        public virtual void Send(string message)
        {
            _notifier.Send(message);
        }
    }
}
