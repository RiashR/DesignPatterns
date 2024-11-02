using ClaimsProcessor.Classes.Events;

namespace ClaimsProcessor.Services.Interfaces
{
    /// <summary>
    /// Service interface for handling fraud detection operations.
    /// </summary>
    public interface IFraudDetectionService
    {
        /// <summary>
        /// Processes the fraud check for a given claim validation event.
        /// </summary>
        /// <param name="claimEvent">The event containing details of the claim to validate.</param>
        void ValidateClaim(ValidateClaimEvent claimEvent);
    }
}
