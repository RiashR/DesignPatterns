using ClaimsProcessor.Classes;
using ClaimsProcessor.Classes.Events;
using ClaimsProcessor.Services;

namespace ClaimsProcessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the mediator
            var mediator = new ClaimMediator();

            // Create services and register them with the mediator
            var fraudDetectionService = new FraudDetectionService(mediator);
            _ = new ClaimApprovalService(mediator);

            // Trigger a claim validation, which notifies the mediator to approve the claim
            fraudDetectionService.ValidateClaim(new ValidateClaimEvent("Claim123"));

            Console.ReadLine();
        }
    }
}
