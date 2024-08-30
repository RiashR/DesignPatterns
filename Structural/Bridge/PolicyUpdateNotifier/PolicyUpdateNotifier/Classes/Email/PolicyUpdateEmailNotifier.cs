using PolicyUpdateNotifier.Interfaces;

namespace PolicyUpdateNotifier.Classes.Email
{
    /// <summary>
    /// Implements the <see cref="IPolicyUpdateNotifier{EmailChannelInfo}"/> interface for email notifications.
    /// </summary>
    public class PolicyUpdateEmailNotifier : IPolicyUpdateNotifier<EmailChannelInfo>
    {
        private readonly ICommunicationChannel<EmailChannelInfo> _communicationChannel;

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyUpdateEmailNotifier"/> class.
        /// </summary>
        /// <param name="communicationChannel">The email communication channel.</param>
        public PolicyUpdateEmailNotifier(ICommunicationChannel<EmailChannelInfo> communicationChannel)
        {
            _communicationChannel = communicationChannel;
        }

        /// <summary>
        /// Notifies the client about policy updates via email.
        /// </summary>
        /// <param name="info">The email channel information.</param>
        /// <param name="message">The message containing the details of the policy update.</param>
        public void Notify(EmailChannelInfo info, string message)
        {
            _communicationChannel.SendMessage(info, message);
        }
    }
}
