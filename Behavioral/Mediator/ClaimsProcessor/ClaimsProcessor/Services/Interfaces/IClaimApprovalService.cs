using ClaimsProcessor.Classes.Events;

namespace ClaimsProcessor.Services.Interfaces
{
    /// <summary>
    /// Service interface for handling claim approval operations.
    /// </summary>
    public interface IClaimApprovalService
    {
        /// <summary>
        /// Approves a claim based on a completed fraud check event.
        /// </summary>
        /// <param name="claimEvent">The event containing details of the fraud-checked claim.</param>
        void ApproveClaim(FraudCheckCompletedEvent claimEvent);
    }
}
