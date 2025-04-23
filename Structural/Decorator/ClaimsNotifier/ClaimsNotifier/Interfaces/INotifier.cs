namespace ClaimsNotifier.Interfaces
{
    // The base notifier interface
    public interface INotifier
    {
        void Send(string message);
    }
}
