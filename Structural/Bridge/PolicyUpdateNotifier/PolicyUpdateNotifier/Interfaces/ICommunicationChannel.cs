namespace PolicyUpdateNotifier.Interfaces
{
    /// <summary>
    /// Defines a contract for sending messages through a communication channel.
    /// </summary>
    /// <typeparam name="TChannelInfo">The type of the communication channel information.</typeparam>
    public interface ICommunicationChannel<TChannelInfo>
    {
        /// <summary>
        /// Sends a message using the specified communication channel information.
        /// </summary>
        /// <param name="info">The communication channel information.</param>
        /// <param name="message">The message to be sent.</param>
        void SendMessage(TChannelInfo info, string message);
    }
}
