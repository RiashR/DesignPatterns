namespace PolicyUpdateNotifier.Classes.Email
{
    /// <summary>
    /// Represents the details required for email communication.
    /// </summary>
    public class EmailChannelInfo
    {
        public string Recipient { get; }
        public string SmtpServer { get; }
        public string EmailAddress { get; }

        /// <summary>
        ///  /// Initializes a new instance of the <see cref="EmailChannelInfo"/> class.
        /// </summary>
        /// <param name="recipient"></param>
        /// <param name="smtpServer"></param>
        /// <param name="emailAddress"></param>
        public EmailChannelInfo(string recipient, string smtpServer, string emailAddress)
        {
            Recipient = recipient;
            SmtpServer = smtpServer;
            EmailAddress = emailAddress;
        }
    }
}
