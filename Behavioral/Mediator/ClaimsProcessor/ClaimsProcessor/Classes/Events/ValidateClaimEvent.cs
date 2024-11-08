using ClaimsProcessor.Interfaces;

namespace ClaimsProcessor.Classes.Events
{
    /// <summary>
    /// Event that represents the validation of a claim.
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="ValidateClaimEvent"/> class.
    /// </remarks>
    /// <param name="claimId">The ID of the claim to be validated.</param>
    public class ValidateClaimEvent(string claimId) : IClaimEvent
    {

        /// <summary>
        /// Gets the ID of the claim to be validated.
        /// </summary>
        public string ClaimId { get; } = claimId;
    }
}
