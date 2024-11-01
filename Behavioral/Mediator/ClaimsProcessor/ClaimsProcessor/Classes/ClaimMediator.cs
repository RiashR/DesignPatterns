using ClaimsProcessor.Interfaces;

namespace ClaimsProcessor.Classes
{
    /// <summary>
    /// The concrete mediator class that implements claim processing coordination between different services.
    /// </summary>
    public class ClaimMediator : IClaimMediator
    {
        private List<IService> _services = new List<IService>();

        /// <summary>
        /// Registers a service with the mediator and sets the mediator for that service.
        /// </summary>
        /// <param name="service">The service to register.</param>
        public void RegisterService(IService service)
        {
            _services.Add(service);
            service.SetMediator(this);
        }

        /// <summary>
        /// Notifies all registered services about an action taken on a specific claim,
        /// excluding the service that triggered the action.
        /// </summary>
        /// <param name="claimId">The ID of the claim being processed.</param>
        /// <param name="action">The action taken on the claim.</param>
        /// <param name="sender">The service that triggered the notification.</param>
        public void Notify(string claimId, string action, IService sender)
        {
            foreach (var service in _services)
            {
                if (service != sender)
                {
                    service.Process(claimId, action);
                }
            }
        }
    }
}
