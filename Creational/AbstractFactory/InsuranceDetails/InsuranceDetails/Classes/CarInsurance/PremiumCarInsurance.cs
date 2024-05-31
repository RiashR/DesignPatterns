using InsuranceDetails.Interfaces;

namespace InsuranceDetails.Classes.CarInsurance
{
    public class PremiumCarInsurance : ICarInsurance
    {
        public void GetCarInsuranceDetails() => Console.WriteLine("Premium Car Insurance: provides comprehensive cover.");
    }
}
