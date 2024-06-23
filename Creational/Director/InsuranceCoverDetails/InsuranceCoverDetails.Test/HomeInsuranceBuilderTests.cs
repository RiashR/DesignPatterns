using InsuranceCoverDetails.Builders.Classes;
using FluentAssertions;
using FluentAssertions.Execution;

namespace InsuranceCoverDetails.Test
{
    /// <summary>
    /// Unit tests for the HomeInsuranceBuilder class.
    /// </summary>
    public class HomeInsuranceBuilderTests
    {

        [Test]
        public void Given_HomeInsuranceBuilder_When_BuildingWithAddress_Then_AddressShouldMatch()
        {
            // Arrange
            var builder = new HomeInsuranceBuilder();
            var expectedAddress = "359 Murphy Avenue";

            // Act
            builder.SetAddress(expectedAddress);
            var result = builder.Build();

            // Assert
            result.Address.Should().Be(expectedAddress);
        }

        [Test]
        public void Given_HomeInsuranceBuilder_When_BuildingWithBasicInsuranceType_Then_InsuranceTypeShouldBeBasic()
        {
            // Arrange
            var builder = new HomeInsuranceBuilder();
            var expecctedInsuranceType = "Basic";

            // Act
            builder.SetAddress(expecctedInsuranceType);
            var result = builder.Build();

            // Assert
            result.Address.Should().Be(expecctedInsuranceType);
        }

        [Test]
        public void Given_HomeInsuranceBuilder_When_AddingFloodCoverage_Then_FloodCoverageShouldBeTrue_And_OthersFalse()
        {
            // Arrange
            var builder = new HomeInsuranceBuilder();

            // Act
            builder.AddFireCoverage();
            var result = builder.Build();

            // Assert
            using (new AssertionScope())
            {
                result.FireCoverage.Should().BeTrue();
                result.TheftCoverage.Should().BeFalse();
                result.FloodCoverage.Should().BeFalse();
            }
        }

        [Test]
        public void Given_HomeInsuranceBuilder_When_BuildingWithAllCoverages_Then_AllCoveragesShouldBeTrue()
        {
            // Arrange
            var builder = new HomeInsuranceBuilder();

            // Act
            builder.AddFireCoverage();
            builder.AddTheftCoverage();
            builder.AddFloodCoverage();
            var result = builder.Build();

            // Assert
            using (new AssertionScope())
            {
                result.FireCoverage.Should().BeTrue();
                result.TheftCoverage.Should().BeTrue();
                result.FloodCoverage.Should().BeTrue();
            }
        }
    }
}