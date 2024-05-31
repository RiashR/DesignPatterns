using InsuranceDetails.Classes.CarInsurance;
using InsuranceDetails.Classes.HealthInsurance;
using InsuranceDetails.Interfaces;

namespace InsuranceDetails.Factories
{
    public class BasicInsuranceFactory : IInsuranceFactory
    {
        public ICarInsurance CreateCarInsurance() => new BasicCarInsurance();

        public IHealthInsurance CreateHealthInsurance() => new BasicHealthInsurance();

    }
}
