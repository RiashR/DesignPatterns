using NSubstitute;
using PolicyUpdateNotifier.Classes.Email;
using PolicyUpdateNotifier.Classes.Sms;
using PolicyUpdateNotifier.Interfaces;


namespace PolicyUpdateNotifier.Tests
{
    [TestFixture]
    public class PolicyUpdateNotifierTests
    {
        [Test]
        public void Notify_ShouldSendEmail_WithCorrectDetails()
        {
            // Arrange
            var communicationChannel = Substitute.For<ICommunicationChannel<EmailChannelInfo>>();
            var notifier = new PolicyUpdateEmailNotifier(communicationChannel);
            var emailInfo = new EmailChannelInfo("client@example.com", "smtp.example.com", "client@example.com");
            var policyDetails = "Your policy number 12345 has been updated with new coverage details.";

            // Act
            notifier.Notify(emailInfo, policyDetails);

            // Assert
            communicationChannel.Received(1).SendMessage(emailInfo, policyDetails);
        }

        [Test]
        public void Notify_ShouldSendSms_WithCorrectDetails()
        {
            // Arrange
            var communicationChannel = Substitute.For<ICommunicationChannel<SmsChannelInfo>>();
            var notifier = new PolicyUpdateSmsNotifier(communicationChannel);
            var smsInfo = new SmsChannelInfo("John Doe", "Network A", "123-456-7890");
            var policyDetails = "Your policy number 12345 has been updated.";

            // Act
            notifier.Notify(smsInfo, policyDetails);

            // Assert
            communicationChannel.Received(1).SendMessage(smsInfo, policyDetails);
        }
    }
}