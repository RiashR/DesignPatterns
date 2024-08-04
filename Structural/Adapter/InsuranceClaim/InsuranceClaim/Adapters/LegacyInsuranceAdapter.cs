using InsuranceClaim.Classes;
using InsuranceClaim.Interfaces;

namespace InsuranceClaim.Adapters
{
    /// <summary>
    /// Adapter for the legacy insurance service to make it compatible with IInsuranceService.
    /// </summary>
    public class LegacyInsuranceAdapter : IInsuranceService
    {
        private readonly LegacyInsuranceService _legacyInsuranceService;

        public LegacyInsuranceAdapter(LegacyInsuranceService legacyInsuranceService)
        {
            _legacyInsuranceService = legacyInsuranceService;
        }

        // Implement the ProcessClaim method to adapt the legacy method.
        public void ProcessClaim(ClaimDetails claimDetails)
        {
            _legacyInsuranceService.SubmitClaim(claimDetails);
        }
    }
}
