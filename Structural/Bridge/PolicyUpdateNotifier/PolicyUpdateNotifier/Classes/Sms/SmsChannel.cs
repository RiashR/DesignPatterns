using PolicyUpdateNotifier.Interfaces;

namespace PolicyUpdateNotifier.Classes.Sms
{
    /// <summary>
    /// Implements the <see cref="ICommunicationChannel{SmsChannelInfo}"/> interface for SMS communications.
    /// </summary>
    public class SmsChannel : ICommunicationChannel<SmsChannelInfo>
    {
        /// <summary>
        /// Sends an SMS message using the specified SMS channel information.
        /// </summary>
        /// <param name="info"></param>
        /// <param name="message"></param>
        public void SendMessage(SmsChannelInfo info, string message)
        {
            Console.WriteLine($"Sending SMS via: \n" +
                $"Network - {info.NetworkInfo} \n" +
                $"Contact Number -  {info.CellNumber} \n" +
                $"Details: {message} \n");
        }
    }
}
