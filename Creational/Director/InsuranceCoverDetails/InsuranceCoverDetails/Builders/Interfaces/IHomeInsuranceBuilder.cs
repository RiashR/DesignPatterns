using InsuranceCoverDetails.Models;

namespace InsuranceCoverDetails.Builders.Interfaces
{
    /// <summary>
    /// Defines the methods for building a home insurance policy.
    /// </summary>
    public interface IHomeInsuranceBuilder
    {
        void SetAddress(string address);

        void SetValue(double value);

        void AddFireCoverage();

        void AddTheftCoverage();

        void AddFloodCoverage();

        void SetInsuranceType(string insuranceType);

        HomeInsurance Build();
    }
}
