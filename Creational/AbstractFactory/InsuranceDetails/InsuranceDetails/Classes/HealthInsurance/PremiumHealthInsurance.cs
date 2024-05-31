using InsuranceDetails.Interfaces;

namespace InsuranceDetails.Classes.HealthInsurance
{
    public class PremiumHealthInsurance : IHealthInsurance
    {
        public void GetHealthInsuranceDetails() => Console.WriteLine("Premium Health Insurance: Covers general health issues, dental and eyecare.");
    }
}
