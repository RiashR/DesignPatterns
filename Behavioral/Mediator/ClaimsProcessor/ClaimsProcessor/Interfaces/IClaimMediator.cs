namespace ClaimsProcessor.Interfaces
{
    /// <summary>
    /// Defines the contract for a mediator that coordinates claims processing between different services.
    /// </summary>
    public interface IClaimMediator
    {
        /// <summary>
        /// Registers a service with the mediator.
        /// </summary>
        /// <param name="service">The service to register.</param>
        void RegisterService(IService service);

        /// <summary>
        /// Notifies all services about an action taken on a specific claim.
        /// </summary>
        /// <param name="claimId">The ID of the claim being processed.</param>
        /// <param name="action">The action taken on the claim.</param>
        /// <param name="sender">The service that triggered the notification.</param>
        void Notify(string claimId, string action, IService sender);
    }
}