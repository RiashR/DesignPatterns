namespace ClaimsProcessor.Interfaces
{
    /// <summary>
    /// Defines the contract for a service in the claim processing system.
    /// </summary>
    public interface IService
    {
        /// <summary>
        /// Sets the mediator for the service.
        /// </summary>
        /// <param name="mediator">The mediator to be set.</param>
        void SetMediator(IClaimMediator mediator);

        /// <summary>
        /// Processes a specific claim based on the action taken.
        /// </summary>
        /// <param name="claimId">The ID of the claim being processed.</param>
        /// <param name="action">The action to be processed.</param>
        void Process(string claimId, string action);
    }
}
