using ClaimsProcessor.Interfaces;

namespace ClaimsProcessor.Services
{
    /// <summary>
    /// A concrete service that handles fraud detection in the claims process.
    /// </summary>
    public class FraudDetectionService : IService
    {
        private IClaimMediator _mediator;

        /// <summary>
        /// Sets the mediator for the service.
        /// </summary>
        /// <param name="mediator">The mediator to set.</param>
        public void SetMediator(IClaimMediator mediator) => _mediator = mediator;

        /// <summary>
        /// Processes a fraud detection action on a specific claim.
        /// </summary>
        /// <param name="claimId">The ID of the claim being processed.</param>
        /// <param name="action">The action to be processed.</param>
        public void Process(string claimId, string action)
        {
            if (action == "Validate")
            {
                Console.WriteLine($"[Fraud Detection] - Processing claim {claimId}");
                _mediator.Notify(claimId, "FraudCheckCompleted", this);
            }
        }
    }
}
