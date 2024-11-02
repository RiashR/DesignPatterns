using ClaimsProcessor.Classes;
using ClaimsProcessor.Classes.Events;
using ClaimsProcessor.Services.Interfaces;
using NSubstitute;

namespace ClaimsProcessor.Tests
{

    /// <summary>
    /// Test suite for validating the ClaimMediator functionality.
    /// </summary>
    [TestFixture]
    public class ClaimMediatorTests
    {
        /// <summary>
        /// Tests that FraudDetectionService notifies ClaimApprovalService upon claim validation completion.
        /// </summary>
        [Test]
        public void FraudDetectionService_NotifiesMediator_OnClaimValidation()
        {
            // Arrange
            var mediator = new ClaimMediator();
            var fraudDetectionService = Substitute.For<IFraudDetectionService>();
            var claimApprovalService = Substitute.For<IClaimApprovalService>();

            mediator.RegisterFraudDetectionService(fraudDetectionService);
            mediator.RegisterClaimApprovalService(claimApprovalService);

            const string claimId = "Claim123";
            var validateClaimEvent = new ValidateClaimEvent(claimId);

            fraudDetectionService.When(x => x.ValidateClaim(validateClaimEvent))
                .Do(_ => mediator.Notify(new FraudCheckCompletedEvent(claimId)));

            // Act
            fraudDetectionService.ValidateClaim(validateClaimEvent);

            // Assert
            claimApprovalService.Received(1).ApproveClaim(Arg.Is<FraudCheckCompletedEvent>(e => e.ClaimId == claimId));
        }

        /// <summary>
        /// Tests that ClaimApprovalService is not notified unless triggered by a fraud check.
        /// </summary>
        [Test]
        public void ClaimApprovalService_DoesNotReceiveNotification_WhenNotTriggeredByFraudCheck()
        {
            // Arrange
            var mediator = new ClaimMediator();
            var fraudDetectionService = Substitute.For<IFraudDetectionService>();
            var claimApprovalService = Substitute.For<IClaimApprovalService>();

            mediator.RegisterFraudDetectionService(fraudDetectionService);
            mediator.RegisterClaimApprovalService(claimApprovalService);

            const string claimId = "Claim123";

            // Act
            mediator.Notify(new FraudCheckCompletedEvent(claimId));

            // Assert
            fraudDetectionService.DidNotReceive().ValidateClaim(Arg.Any<ValidateClaimEvent>());
        }
    }
    }
