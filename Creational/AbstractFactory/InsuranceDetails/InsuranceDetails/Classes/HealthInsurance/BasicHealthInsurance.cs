using InsuranceDetails.Interfaces;

namespace InsuranceDetails.Classes.HealthInsurance
{
    public class BasicHealthInsurance : IHealthInsurance
    {
        public void GetHealthInsuranceDetails() => Console.WriteLine("Basic Health Insurance: Covers general health issues");
    }
}
