using FluentAssertions;
using InsuranceDetails.Classes.CarInsurance;
using InsuranceDetails.Classes.HealthInsurance;
using InsuranceDetails.Factories;
using InsuranceDetails.Interfaces;

namespace InsuranceDetails.Tests
{
    [TestFixture]
    public class InsuranceFactoryTests
    {
        private IInsuranceFactory CreateBasicFactory() => new BasicInsuranceFactory();
        private IInsuranceFactory CreatePremiumFactory() => new PremiumInsuranceFactory();

        [Test(Description = "Basic Health Insurance")]
        public void GivenBasicInsuranceFactory_WhenCreatingHealthInsurance_ThenReturnBasicHealthInsurance()
        {
            // Arrange
            var factory = CreateBasicFactory();

            // Act
            IHealthInsurance healthInsurance = factory.CreateHealthInsurance();

            //Assert
            healthInsurance.Should().BeAssignableTo<BasicHealthInsurance>();
        }

        [Test(Description = "Basic Car Insurance")]
        public void GivenBasicInsuranceFactory_WhenCreatingCarInsurance_ThenReturnBasicCarInsurance()
        {
            // Arrange
            var factory = CreateBasicFactory();

            // Act
            ICarInsurance carInsurance = factory.CreateCarInsurance();

            //Assert
            carInsurance.Should().BeAssignableTo<BasicCarInsurance>();
        }

        [Test(Description = "Premium Health Insurance")]
        public void GivenPremiumInsuranceFactory_WhenCreatingHealthInsurance_ThenReturnPremiumHealthInsurance()
        {
            // Arrange
            var factory = CreatePremiumFactory();

            // Act
            IHealthInsurance healthInsurance = factory.CreateHealthInsurance();

            //Assert
            healthInsurance.Should().BeAssignableTo<PremiumHealthInsurance>();
        }

        [Test(Description = "Premium Car Insurance")]
        public void GivenPremiumInsuranceFactory_WhenCreatingCarInsurance_ThenReturnPremiumCarInsurance()
        {
            // Arrange
            var factory = CreatePremiumFactory();

            // Act
            ICarInsurance carInsurance = factory.CreateCarInsurance();

            //Assert
            carInsurance.Should().BeAssignableTo<PremiumCarInsurance>();
        }

        [Test(Description = "Null Factory")]
        public void GivenNullFactory_WhenCreatingClient_ThenThrowsArgumentNullException()
        {
            // Arrange
            IInsuranceFactory factory = null;

            // Act
            Action act = () => new Client.Client(factory);

            // Assert
            act.Should().Throw<ArgumentNullException>();
        }
    }
}