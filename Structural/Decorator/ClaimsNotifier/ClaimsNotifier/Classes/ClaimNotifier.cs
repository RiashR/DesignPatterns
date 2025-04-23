using ClaimsNotifier.Interfaces;

namespace ClaimsNotifier.Classes
{
    // The core logic: base claim notifier
    public class ClaimNotifier : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine($"[ClaimNotifier] Claim submitted: {message}");
        }
    }
}
