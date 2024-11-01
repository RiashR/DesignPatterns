using ClaimsProcessor.Classes;
using ClaimsProcessor.Services;
using FluentAssertions;
using NSubstitute;

namespace ClaimsProcessor.Tests
{
    [TestFixture]
    public class Tests
    {
        [TestFixture]
        public class ClaimMediatorTests
        {
            /// <summary>
            /// Verifies that when FraudDetectionService processes a claim with the "Validate" action,
            /// it notifies the mediator, which then informs ClaimApprovalService about the "FraudCheckCompleted" action.
            /// </summary>
            [Test]
            public void FraudDetectionService_NotifiesMediator_OnClaimValidation()
            {
                // Arrange
                var mediator = new ClaimMediator();
                var fraudDetectionService = Substitute.For<FraudDetectionService>();
                var claimApprovalService = Substitute.For<ClaimApprovalService>();

                mediator.RegisterService(fraudDetectionService);
                mediator.RegisterService(claimApprovalService);

                const string claimId = "Claim123";

                // Set up fraudDetectionService to notify the mediator but do not expect it to receive further notifications
                fraudDetectionService.When(x => x.Process(claimId, "Validate"))
                    .Do(_ => mediator.Notify(claimId, "FraudCheckCompleted", fraudDetectionService));

                // Act
                fraudDetectionService.Process(claimId, "Validate");

                // Assert
                claimApprovalService.Received(1).Process(claimId, "FraudCheckCompleted");
            }

            /// <summary>
            /// Ensures that FraudDetectionService does not notify the mediator when it processes an unrelated action,
            /// such as "Approve", without involving FraudDetectionService or triggering other services.
            /// </summary>
            [Test]
            public void ClaimApprovalService_DoesNotNotifyMediator_WhenNotTriggeredByFraudCheck()
            {
                // Arrange
                var mediator = new ClaimMediator();
                var fraudDetectionService = Substitute.For<FraudDetectionService>();
                var claimApprovalService = Substitute.For<ClaimApprovalService>();

                mediator.RegisterService(fraudDetectionService);
                mediator.RegisterService(claimApprovalService);

                const string claimId = "Claim123";

                // Act
                fraudDetectionService.Process(claimId, "Approve");

                // Assert
                // FraudDetectionService should not be called since it was not notified by ClaimApprovalService
                fraudDetectionService.DidNotReceive().Process(Arg.Any<string>(), Arg.Any<string>());
                fraudDetectionService.ReceivedCalls().Should().BeEmpty();
            }


            /// <summary>
            /// Confirms that the mediator only notifies services other than the one that triggered the notification.
            /// Specifically, when FraudDetectionService processes "Validate", it should not receive "FraudCheckCompleted".
            /// Only ClaimApprovalService should be notified of "FraudCheckCompleted" as a result.
            /// </summary>
            [Test]
            public void Mediator_NotifiesOnlyOtherServices_NotTheSender()
            {
                // Arrange
                var mediator = new ClaimMediator();
                var fraudDetectionService = Substitute.For<FraudDetectionService>();
                var claimApprovalService = Substitute.For<ClaimApprovalService>();

                mediator.RegisterService(fraudDetectionService);
                mediator.RegisterService(claimApprovalService);

                const string claimId = "Claim123";

                // Set up fraudDetectionService to notify the mediator but do not expect it to receive further notifications
                fraudDetectionService.When(x => x.Process(claimId, "Validate"))
                    .Do(_ => mediator.Notify(claimId, "FraudCheckCompleted", fraudDetectionService));

                // Act
                fraudDetectionService.Process(claimId, "Validate");

                // Assert
                // Ensure fraudDetectionService does not receive "FraudCheckCompleted"
                fraudDetectionService.DidNotReceive().Process(claimId, "FraudCheckCompleted");

                // Ensure that only claimApprovalService receives the "FraudCheckCompleted" notification
                claimApprovalService.Received(1).Process(claimId, "FraudCheckCompleted");
            }

        }
    }
}