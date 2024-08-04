using InsuranceClaim.Adapters;
using InsuranceClaim.Classes;
using InsuranceClaim.Enums;
using NSubstitute;

namespace InsuranceClaim.Tests
{
    public class InsuranceAdapterTests
    {
        [Test]
        public void ProcessClaim_ShouldCallFileInsuranceClaim()
        {
            // Arrange
            var mockNewService = Substitute.For<InsuranceService>();
            var adapter = new InsuranceAdapter(mockNewService);
            var claimDetails = new ClaimDetails
            {
                PolicyType = PolicyType.Basic,
                InsuranceType = InsuranceType.Car,
                Description = "Minor Scratch and Dent",
                Amount = 15000m,
                DateOfClaim = DateTime.Now
            };

            // Act
            adapter.ProcessClaim(claimDetails);

            // Assert
            mockNewService.Received().ProcessInsuranceClaim(claimDetails);
        }
    }
}
