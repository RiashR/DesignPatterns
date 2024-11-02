/// <summary>
/// Interface for a generic claim event with a ClaimId property.
/// </summary>
namespace ClaimsProcessor.Interfaces
{
    public interface IClaimEvent
    {
        /// <summary>
        /// Gets the ID of the claim associated with this event.
        /// </summary>
        string ClaimId { get; }
    }
}
