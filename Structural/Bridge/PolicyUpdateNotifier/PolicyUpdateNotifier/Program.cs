using PolicyUpdateNotifier.Classes.Email;
using PolicyUpdateNotifier.Classes.Sms;
using PolicyUpdateNotifier.Interfaces;

namespace PolicyUpdateNotifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string notificationMessage = "Your policy number 12345 has been updated with new coverage details.";

            // Create communication channel info for Email
            ICommunicationChannel<EmailChannelInfo> emailChannel = new EmailChannel();
            EmailChannelInfo emailInfo = new EmailChannelInfo("John Blake", "smtp.example.com", "client@example.com");

            // Create communication channel info for Sms
            ICommunicationChannel<SmsChannelInfo> smsChannel = new SmsChannel();
            SmsChannelInfo smsInfo = new SmsChannelInfo("John Blake", "Network A", "123-456-7890");

            // Create notifier for Email
            IPolicyUpdateNotifier<EmailChannelInfo> emailNotifier = new PolicyUpdateEmailNotifier(emailChannel);
            emailNotifier.Notify(emailInfo, notificationMessage);

            // Create notifier for Sms
            IPolicyUpdateNotifier<SmsChannelInfo> smsNotifier = new PolicyUpdateSmsNotifier(smsChannel);
            smsNotifier.Notify(smsInfo, notificationMessage);

            Console.ReadLine();
        }
    }
}
