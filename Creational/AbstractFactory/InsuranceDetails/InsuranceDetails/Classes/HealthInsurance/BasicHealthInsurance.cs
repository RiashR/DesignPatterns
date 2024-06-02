using InsuranceDetails.Interfaces;

namespace InsuranceDetails.Classes.HealthInsurance
{
    /// <summary>
    /// Concrete implementation of IHealthInsurance for basic health insurance.
    /// </summary>
    public class BasicHealthInsurance : IHealthInsurance
    {
        public void GetHealthInsuranceDetails() => Console.WriteLine("Basic Health Insurance: Covers general health issues");
    }
}
