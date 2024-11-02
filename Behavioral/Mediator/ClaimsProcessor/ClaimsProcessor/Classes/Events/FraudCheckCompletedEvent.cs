using ClaimsProcessor.Interfaces;

namespace ClaimsProcessor.Classes.Events
{
    /// <summary>
    /// Event that represents the completion of a fraud check for a claim.
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="FraudCheckCompletedEvent"/> class.
    /// </remarks>
    /// <param name="claimId">The ID of the claim that passed the fraud check.</param>
    public class FraudCheckCompletedEvent(string claimId) : IClaimEvent
    {
        /// <summary>
        /// Gets the ID of the claim that passed the fraud check.
        /// </summary>
        public string ClaimId { get; } = claimId;
    }
}
