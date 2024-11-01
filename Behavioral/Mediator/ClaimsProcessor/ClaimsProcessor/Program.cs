using ClaimsProcessor.Classes;
using ClaimsProcessor.Interfaces;
using ClaimsProcessor.Services;

namespace ClaimsProcessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a ClaimMediator instance to coordinate the claims process.
            ClaimMediator mediator = new ClaimMediator();

            // Create services and register them with the mediator.
            IService fraudService = new FraudDetectionService();
            IService approvalService = new ClaimApprovalService();

            mediator.RegisterService(fraudService);
            mediator.RegisterService(approvalService);

            // Trigger the claims process by having the fraud service validate a claim.
            fraudService.Process("Claim123", "Validate");

            Console.ReadLine();
        }
    }
}
