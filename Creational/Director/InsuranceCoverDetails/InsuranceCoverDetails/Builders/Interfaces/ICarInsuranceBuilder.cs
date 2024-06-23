using InsuranceCoverDetails.Models;

namespace InsuranceCoverDetails.Builders.Interfaces
{
    /// <summary>
    /// Defines the methods for building a car insurance policy.
    /// </summary>
    public interface ICarInsuranceBuilder
    {
        void SetCarModel(string carModel);

        void SetYear(int year);

        void AddCollisionCoverage();

        void AddComprehensiveCoverage();

        void SetExcessAmount(double deductible);

        void SetInsuranceType(string insuranceType);

        CarInsurance Build();
    }
}
