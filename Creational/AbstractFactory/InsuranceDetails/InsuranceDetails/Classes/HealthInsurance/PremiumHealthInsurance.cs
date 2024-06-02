using InsuranceDetails.Interfaces;

namespace InsuranceDetails.Classes.HealthInsurance
{
    /// <summary>
    /// Concrete implementation of IHealthInsurance for premium health insurance.
    /// </summary>
    public class PremiumHealthInsurance : IHealthInsurance
    {
        public void GetHealthInsuranceDetails() => Console.WriteLine("Premium Health Insurance: Covers general health issues, dental and eyecare.");
    }
}
