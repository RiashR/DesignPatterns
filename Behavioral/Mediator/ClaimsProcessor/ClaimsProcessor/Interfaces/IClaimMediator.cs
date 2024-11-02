using ClaimsProcessor.Services.Interfaces;

namespace ClaimsProcessor.Interfaces
{
    /// <summary>
    /// Mediator interface for handling interactions between services in the insurance context.
    /// </summary>
    public interface IClaimMediator
    {
        /// <summary>
        /// Registers the fraud detection service with the mediator.
        /// </summary>
        /// <param name="service">The fraud detection service to register.</param>
        void RegisterFraudDetectionService(IFraudDetectionService service);

        /// <summary>
        /// Registers the claim approval service with the mediator.
        /// </summary>
        /// <param name="service">The claim approval service to register.</param>
        void RegisterClaimApprovalService(IClaimApprovalService service);

        /// <summary>
        /// Notifies the mediator of a specific claim event to be routed to the appropriate service.
        /// </summary>
        /// <typeparam name="TEvent">The type of the claim event.</typeparam>
        /// <param name="claimEvent">The event containing claim details.</param>
        void Notify<TEvent>(TEvent claimEvent) where TEvent : IClaimEvent;
    }
}