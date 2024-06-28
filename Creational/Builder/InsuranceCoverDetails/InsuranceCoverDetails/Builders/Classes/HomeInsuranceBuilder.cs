using InsuranceCoverDetails.Builders.Interfaces;
using InsuranceCoverDetails.Models;

namespace InsuranceCoverDetails.Builders.Classes
{
    /// <summary>
    /// Concrete builder for home insurance policies.
    /// </summary>
    public class HomeInsuranceBuilder : IHomeInsuranceBuilder
    {
        private HomeInsurance _homeInsurance = new HomeInsurance();

        public void SetAddress(string address)
        {
            _homeInsurance.Address = address;
        }

        public void SetValue(double value)
        {
            _homeInsurance.Value = value;
        }

        public void AddFireCoverage()
        {
            _homeInsurance.FireCoverage = true;
        }

        public void AddTheftCoverage()
        {
            _homeInsurance.TheftCoverage = true;
        }

        public void AddFloodCoverage()
        {
            _homeInsurance.FloodCoverage = true;
        }

        public void SetInsuranceType(string insuranceType)
        {
            _homeInsurance.InsuranceType = insuranceType;
        }

        public HomeInsurance Build()
        {
            return _homeInsurance;
        }
    }
}

