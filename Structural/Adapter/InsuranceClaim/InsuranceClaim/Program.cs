using InsuranceClaim.Adapters;
using InsuranceClaim.Classes;
using InsuranceClaim.Interfaces;

namespace InsuranceClaim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of LegacyInsuranceService and adapt it using LegacyInsuranceAdapter.
            IInsuranceService legacyInsurance = new LegacyInsuranceAdapter(new LegacyInsuranceService());
            ClaimDetails legacyClaimDetails = LegacyClaimDetails();
            legacyInsurance.ProcessClaim(legacyClaimDetails);

            // Create an instance of NewInsuranceService and adapt it using NewInsuranceAdapter.
            IInsuranceService newInsurance = new InsuranceAdapter(new InsuranceService());
            ClaimDetails claimDetails = ClaimDetails();
            newInsurance.ProcessClaim(claimDetails);
        }

        private static ClaimDetails ClaimDetails()
        {
            return new ClaimDetails
            {
                PolicyType = Enums.PolicyType.Basic,
                InsuranceType = Enums.InsuranceType.Car,
                Description = "Minor Scratch and Dent",
                Amount = 15000m,
                DateOfClaim = DateTime.Now
            };
        }

        private static ClaimDetails LegacyClaimDetails()
        {
            return new ClaimDetails()
            {
                PolicyType = Enums.PolicyType.Premium,
                InsuranceType = Enums.InsuranceType.Home,
                Description = "Burst Geyser",
                Amount = 5000m,
                DateOfClaim = DateTime.Now,
            };
        }
    }
}
