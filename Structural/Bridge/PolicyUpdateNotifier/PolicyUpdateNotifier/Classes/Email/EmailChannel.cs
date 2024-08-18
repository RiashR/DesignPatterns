using PolicyUpdateNotifier.Interfaces;

namespace PolicyUpdateNotifier.Classes.Email
{
    /// <summary>
    /// Implements the <see cref="ICommunicationChannel{EmailChannelInfo}"/> interface for email communications.
    /// </summary>
    public class EmailChannel : ICommunicationChannel<EmailChannelInfo>
    {
        /// <summary>
        /// Sends an email message using the specified email channel information.
        /// </summary>
        /// <param name="info">The email channel information.</param>
        /// <param name="message">The message to be sent.</param>
        public void SendMessage(EmailChannelInfo info, string message)
        {
            Console.WriteLine($"Sending Email via: \n" +
                $"SMTP Server - {info.SmtpServer} \n" +
                $"Recipient -  {info.EmailAddress} \n" +
                $"Details: {message} \n");
        }
    }
}
