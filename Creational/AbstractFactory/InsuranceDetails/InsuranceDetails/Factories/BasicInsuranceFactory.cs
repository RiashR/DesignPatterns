using InsuranceDetails.Classes.CarInsurance;
using InsuranceDetails.Classes.HealthInsurance;
using InsuranceDetails.Interfaces;

namespace InsuranceDetails.Factories
{
    /// <summary>
    /// Concrete implementation of IInsuranceFactory for creating basic insurance products.
    /// </summary>
    public class BasicInsuranceFactory : IInsuranceFactory
    {
        public ICarInsurance CreateCarInsurance() => new BasicCarInsurance();

        public IHealthInsurance CreateHealthInsurance() => new BasicHealthInsurance();

    }
}
