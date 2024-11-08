using ClaimsProcessor.Classes.Events;
using ClaimsProcessor.Interfaces;
using ClaimsProcessor.Services.Interfaces;

namespace ClaimsProcessor.Services
{
    /// <summary>
    /// Implementation of the fraud detection service that performs fraud checks on claims.
    /// </summary>
    public class FraudDetectionService : IFraudDetectionService
    {
        private IClaimMediator _mediator;

        /// <summary>
        /// Initializes a new instance of the <see cref="FraudDetectionService"/> class with a mediator.
        /// </summary>
        /// <param name="mediator">The mediator that will handle event notifications.</param>
        public FraudDetectionService(IClaimMediator mediator)
        {
            _mediator = mediator;
            _mediator.RegisterFraudDetectionService(this);
        }

        /// <inheritdoc/>
        public void ValidateClaim(ValidateClaimEvent claimEvent)
        {
            Console.WriteLine($"Fraud detection completed for: {claimEvent.ClaimId}");
            _mediator.Notify(new FraudCheckCompletedEvent(claimEvent.ClaimId));
        }
    }
}
