using ClaimsProcessor.Classes.Events;
using ClaimsProcessor.Interfaces;
using ClaimsProcessor.Services.Interfaces;

namespace ClaimsProcessor.Services
{
    /// <summary>
    /// Implementation of the claim approval service that approves claims based on fraud check results.
    /// </summary>
    public class ClaimApprovalService : IClaimApprovalService
    {
        private IClaimMediator _mediator;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClaimApprovalService"/> class with a mediator.
        /// </summary>
        /// <param name="mediator">The mediator that will handle event notifications.</param>
        public ClaimApprovalService(IClaimMediator mediator)
        {
            _mediator = mediator;
            _mediator.RegisterClaimApprovalService(this);
        }

        /// <inheritdoc/>
        public void ApproveClaim(FraudCheckCompletedEvent claimEvent)
        {
            Console.WriteLine($"Claim approved for: {claimEvent.ClaimId}");
        }
    }
}