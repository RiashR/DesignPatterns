using ClaimsStateProcessor.Classes;

namespace ClaimsStateProcessor.Interfaces
{
    /// <summary>
    /// Represents the interface for all claim states.
    /// Defines the operations that can be performed on an insurance claim.
    /// </summary>
    public interface IClaimState
    {
        /// <summary>
        /// Handles the submission of a claim.
        /// </summary>
        /// <param name="context">The claim context.</param>
        void SubmitClaim(ClaimContext context);

        /// <summary>
        /// Handles the review of a claim.
        /// </summary>
        /// <param name="context">The claim context.</param>
        void ReviewClaim(ClaimContext context);

        /// <summary>
        /// Handles the approval of a claim.
        /// </summary>
        /// <param name="context">The claim context.</param>
        void ApproveClaim(ClaimContext context);

        /// <summary>
        /// Handles the rejection of a claim.
        /// </summary>
        /// <param name="context">The claim context.</param>
        void RejectClaim(ClaimContext context);
    }
}
