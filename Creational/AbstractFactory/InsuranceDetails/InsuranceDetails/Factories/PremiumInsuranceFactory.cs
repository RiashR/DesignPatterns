using InsuranceDetails.Classes.CarInsurance;
using InsuranceDetails.Classes.HealthInsurance;
using InsuranceDetails.Interfaces;

namespace InsuranceDetails.Factories
{
    /// <summary>
    /// Concrete implementation of IInsuranceFactory for creating premium insurance products.
    /// </summary>
    public class PremiumInsuranceFactory : IInsuranceFactory
    {
        public ICarInsurance CreateCarInsurance() => new PremiumCarInsurance();
        
        public IHealthInsurance CreateHealthInsurance() => new PremiumHealthInsurance();
    }
}
