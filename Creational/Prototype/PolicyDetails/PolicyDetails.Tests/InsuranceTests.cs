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
            var originalCarInsurance = new Insurance(new PolicyHolder("Bruce", "Wayne" ), 1000.00, InsuranceType.Car, PolicyType.Premium);

            // Act
            var clonedInsurance = (Insurance)originalCarInsurance.Clone();

            // Assert
            using (new AssertionScope())
            {
                clonedInsurance.Should().NotBeSameAs(originalCarInsurance);
                clonedInsurance.Should().BeEquivalentTo(originalCarInsurance);
            }
        }

        [Test(Description = "Tests if modifications to the cloned instance do not affect the original instance")]
        public void CarInsurance_ShouldModifyClonedInstanceIndependently()
        {
            // Arrange
            Insurance originalInsurance = OriginalInsurance();

            // Act
            var clonedCarInsurance = (Insurance)originalInsurance.Clone();
            SetClonedInsurance(clonedCarInsurance);

            // Assert
            using (new AssertionScope())
            {
                originalInsurance.Should().BeEquivalentTo(new Insurance(new PolicyHolder("Bruce", "Wayne"), 1000.00, InsuranceType.Car, PolicyType.Premium));
                clonedCarInsurance.Should().BeEquivalentTo( new Insurance(new PolicyHolder("Dick", "Grayson"), 500.00, InsuranceType.Home, PolicyType.Basic));
            }
        }

        private static void SetClonedInsurance(Insurance clonedCarInsurance)
        {
            clonedCarInsurance.PolicyHolder.FirstName = "Dick";
            clonedCarInsurance.PolicyHolder.LastName = "Grayson";
            clonedCarInsurance.Premium = 500.00;
            clonedCarInsurance.PolicyType = PolicyType.Basic;
            clonedCarInsurance.InsuranceType = InsuranceType.Home;
        }

        private static Insurance OriginalInsurance()
        {
            return new Insurance(new PolicyHolder("Bruce", "Wayne"), 1000.00, InsuranceType.Car, PolicyType.Premium);
        }
    }
}