namespace PolicyUpdateNotifier.Classes.Sms
{
    /// <summary>
    /// Represents the details required for SMS communication.
    /// </summary>
    public class SmsChannelInfo
    {
        public string Recipient { get; }
        public string NetworkInfo { get; }
        public string CellNumber { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SmsChannelInfo"/> class.
        /// </summary>
        /// <param name="recipient"></param>
        /// <param name="networkInfo"></param>
        /// <param name="cellNumber"></param>
        public SmsChannelInfo(string recipient, string networkInfo, string cellNumber)
        {
            Recipient = recipient;
            NetworkInfo = networkInfo;
            CellNumber = cellNumber;
        }
    }
}
