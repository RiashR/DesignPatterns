using PolicyUpdateNotifier.Interfaces;

namespace PolicyUpdateNotifier.Classes.Sms
{
    /// <summary>
    /// Implements the <see cref="IPolicyUpdateNotifier{SmsChannelInfo}"/> interface for SMS notifications.
    /// </summary>
    public class PolicyUpdateSmsNotifier : IPolicyUpdateNotifier<SmsChannelInfo>
    {
        private readonly ICommunicationChannel<SmsChannelInfo> _communicationChannel;

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyUpdateSmsNotifier"/> class.
        /// </summary>
        /// <param name="communicationChannel">The SMS communication channel.</param>
        public PolicyUpdateSmsNotifier(ICommunicationChannel<SmsChannelInfo> communicationChannel)
        {
            _communicationChannel = communicationChannel;
        }

        /// <summary>
        /// Notifies the client about policy updates via SMS.
        /// </summary>
        /// <param name="info">The SMS channel information.</param>
        /// <param name="message">The message containing the details of the policy update.</param>
        public void Notify(SmsChannelInfo info, string message)
        {
            _communicationChannel.SendMessage(info, message);
        }
    }

}
