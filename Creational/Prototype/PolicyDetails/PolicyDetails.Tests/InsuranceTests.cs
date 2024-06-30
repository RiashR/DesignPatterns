using FluentAssertions;
using FluentAssertions.Execution;
using PolicyDetails.Classes;
using PolicyDetails.Enums;

namespace PolicyDetails.Tests
{
    public class InsuranceTests
    {
        [Test (Description = "Clone method creates a new instance that is not the same as the original but has identical property values.")]
        public void CarInsurance_ShouldCloneSuccessfully()
        {
            // Arrange
            var originalCarInsurance = new Insurance("Bruce", "Wayne", 1000.00, InsuranceType.Car, PolicyType.Premium);

            // Act
            var clonedCarInsurance = (Insurance)originalCarInsurance.Clone();

            // Assert
            using (new AssertionScope())
            {
                clonedCarInsurance.Should().NotBeSameAs(originalCarInsurance);
                clonedCarInsurance.Should().BeEquivalentTo(originalCarInsurance);
            }
        }

        [Test(Description = "Tests if modifications to the cloned instance do not affect the original instance")]
        public void CarInsurance_ShouldModifyClonedInstanceIndependently()
        {
            Insurance originalCarInsurance = OriginalCarInsurance();

            // Act
            var clonedCarInsurance = (Insurance)originalCarInsurance.Clone();
            SetClonedInsurance(clonedCarInsurance);

            // Assert
            using (new AssertionScope())
            {
                originalCarInsurance.Should().BeEquivalentTo(new Insurance("Bruce", "Wayne", 1000.00, InsuranceType.Car, PolicyType.Premium));
                clonedCarInsurance.Should().BeEquivalentTo( new Insurance("Dick", "Grayson", 500.00, InsuranceType.Home, PolicyType.Basic));
            }
        }

        private static void SetClonedInsurance(Insurance clonedCarInsurance)
        {
            clonedCarInsurance.FirstName = "Dick";
            clonedCarInsurance.LastName = "Grayson";
            clonedCarInsurance.Premium = 500.00;
            clonedCarInsurance.PolicyType = PolicyType.Basic;
            clonedCarInsurance.InsuranceType = InsuranceType.Home;
        }

        private static Insurance OriginalCarInsurance()
        {
            return new Insurance("Bruce", "Wayne", 1000.00, InsuranceType.Car, PolicyType.Premium);
        }
    }
}