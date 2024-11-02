using ClaimsProcessor.Classes.Events;
using ClaimsProcessor.Interfaces;
using ClaimsProcessor.Services.Interfaces;

namespace ClaimsProcessor.Classes
{
    /// <summary>
    /// Implementation of a claim mediator that routes claim events to appropriate services.
    /// </summary>
    public class ClaimMediator : IClaimMediator
    {
        private IFraudDetectionService _fraudDetectionService;
        private IClaimApprovalService _claimApprovalService;

        /// <inheritdoc/>
        public void RegisterFraudDetectionService(IFraudDetectionService service) =>
            _fraudDetectionService = service;

        /// <inheritdoc/>
        public void RegisterClaimApprovalService(IClaimApprovalService service) =>
            _claimApprovalService = service;

        /// <inheritdoc/>
        public void Notify<TEvent>(TEvent claimEvent) where TEvent : IClaimEvent
        {
            // Route specific events to appropriate services
            switch (claimEvent)
            {
                case ValidateClaimEvent validateClaimEvent:
                    _fraudDetectionService?.ValidateClaim(validateClaimEvent);
                    break;
                case FraudCheckCompletedEvent fraudCheckCompletedEvent:
                    _claimApprovalService?.ApproveClaim(fraudCheckCompletedEvent);
                    break;
            }
        }
    }
}
