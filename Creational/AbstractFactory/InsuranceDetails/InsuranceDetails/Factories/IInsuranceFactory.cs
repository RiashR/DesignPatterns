using InsuranceDetails.Interfaces;

namespace InsuranceDetails.Factories
{
    public interface IInsuranceFactory
    {
        IHealthInsurance CreateHealthInsurance();
        ICarInsurance CreateCarInsurance();
    }
}
