using ClaimsProcessor.Interfaces;

namespace ClaimsProcessor.Services
{
    /// <summary>
    /// A concrete service that handles claim approval in the claims process.
    /// </summary>
    public class ClaimApprovalService : IService
    {
        private IClaimMediator _mediator;

        /// <summary>
        /// Sets the mediator for the service.
        /// </summary>
        /// <param name="mediator">The mediator to set.</param>
        public void SetMediator(IClaimMediator mediator) => _mediator = mediator;

        /// <summary>
        /// Processes a claim approval action based on the results of previous actions (e.g., fraud check).
        /// </summary>
        /// <param name="claimId">The ID of the claim being processed.</param>
        /// <param name="action">The action to be processed.</param>
        public void Process(string claimId, string action)
        {
            if (action == "FraudCheckCompleted")
            {
                Console.WriteLine($"[Claim Approval] - Approving claim {claimId} after fraud check.");
            }
        }
    }
}