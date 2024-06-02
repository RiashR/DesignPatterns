using InsuranceDetails.Interfaces;

namespace InsuranceDetails.Factories
{
    /// <summary>
    /// Abstract Factory interface for creating insurance products.
    /// </summary>
    public interface IInsuranceFactory
    {
        IHealthInsurance CreateHealthInsurance();
        ICarInsurance CreateCarInsurance();
    }
}
