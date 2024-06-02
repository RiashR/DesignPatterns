using InsuranceDetails.Interfaces;

namespace InsuranceDetails.Classes.CarInsurance
{
    /// <summary>
    /// Concrete implementation of ICarInsurance for premium car insurance.
    /// </summary>
    public class PremiumCarInsurance : ICarInsurance
    {
        public void GetCarInsuranceDetails() => Console.WriteLine("Premium Car Insurance: provides comprehensive cover.");
    }
}
