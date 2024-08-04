using InsuranceClaim.Classes;
using InsuranceClaim.Interfaces;

namespace InsuranceClaim.Adapters
{
    /// <summary>
    /// Adapter for the new insurance service to make it compatible with IInsuranceService.
    /// </summary>
    public class InsuranceAdapter : IInsuranceService
    {
        private readonly InsuranceService _newInsuranceService;

        public InsuranceAdapter(InsuranceService newInsuranceService)
        {
            _newInsuranceService = newInsuranceService;
        }

        // Implement the ProcessClaim method to adapt the new method.
        public void ProcessClaim(ClaimDetails claimDetails)
        {
            _newInsuranceService.ProcessInsuranceClaim(claimDetails);
        }
    }
}
