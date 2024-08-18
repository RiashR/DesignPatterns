namespace PolicyUpdateNotifier.Interfaces
{
    /// <summary>
    /// Defines a contract for notifying clients about policy updates.
    /// </summary>
    /// <typeparam name="TChannelInfo">The type of the communication channel information.</typeparam>
    public interface IPolicyUpdateNotifier<TChannelInfo>
    {
        /// <summary>
        /// Notifies the client about policy updates using the specified channel information.
        /// </summary>
        /// <param name="info">The communication channel information.</param>
        /// <param name="policyDetails">The details of the policy update.</param>
        void Notify(TChannelInfo info, string policyDetails);
    }
}
