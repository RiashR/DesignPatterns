using ClaimsProcessor.Classes;
using ClaimsProcessor.Classes.Events;
using ClaimsProcessor.Services;

namespace ClaimsProcessor
{
    /// <summary>
    /// Main entry point for the insurance mediator program.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the mediator
            var mediator = new ClaimMediator();

            // Create services and register them with the mediator
            _ = new FraudDetectionService(mediator);
            _ = new ClaimApprovalService(mediator);

            // Trigger a claim validation through the mediator
            mediator.Notify(new ValidateClaimEvent("Claim123"));

            Console.ReadLine();
        }
    }
}
