using PolicyUpdateNotifier.Classes.Email;
using PolicyUpdateNotifier.Classes.Sms;
using PolicyUpdateNotifier.Interfaces;

namespace PolicyUpdateNotifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string message = "Your policy number 12345 has been updated with new coverage details.";

            // Create communication channel info for Email
            ICommunicationChannel<EmailChannelInfo> emailChannel = new EmailChannel();
            var emailInfo = new EmailChannelInfo("John Blake", "smtp.example.com", "client@example.com");

            // Create notifier for Email
            IPolicyUpdateNotifier<EmailChannelInfo> emailNotifier = new PolicyUpdateEmailNotifier(emailChannel);
            emailNotifier.Notify(emailInfo, message);

            // Create communication channel info for Sms
            ICommunicationChannel<SmsChannelInfo> smsChannel = new SmsChannel();
            var smsInfo = new SmsChannelInfo("John Blake", "Network A", "123-456-7890");

            // Create notifier for Sms
            IPolicyUpdateNotifier<SmsChannelInfo> smsNotifier = new PolicyUpdateSmsNotifier(smsChannel);
            smsNotifier.Notify(smsInfo, message);

            Console.ReadLine();
        }
    }
}
