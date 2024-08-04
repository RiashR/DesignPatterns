using InsuranceClaim.Adapters;
using InsuranceClaim.Classes;
using InsuranceClaim.Enums;
using NSubstitute;

namespace InsuranceClaim.Tests
{
    [TestFixture]
    public class LegacyInsuranceAdapterTests
    {
        [Test]
        public void ProcessClaim_ShouldCallSubmitInsuranceClaim()
        {
            // Arrange
            var mockLegacyService = Substitute.For<LegacyInsuranceService>();
            var adapter = new LegacyInsuranceAdapter(mockLegacyService);
            var claimDetails = new ClaimDetails
            {
                PolicyType = PolicyType.Premium,
                InsuranceType = InsuranceType.Home,
                Description = "Burst Geyser",
                Amount = 5000m,
                DateOfClaim = DateTime.Now,
            };

            // Act
            adapter.ProcessClaim(claimDetails);

            // Assert
            mockLegacyService.Received().SubmitClaim(claimDetails);
        }
    }
}