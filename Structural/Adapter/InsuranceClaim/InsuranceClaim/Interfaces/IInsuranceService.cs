using InsuranceClaim.Classes;

namespace InsuranceClaim.Interfaces
{
    /// <summary>
    /// Common interface that both the legacy and new insurance services will implement.
    /// </summary>
    public interface IInsuranceService
    {
        void ProcessClaim(ClaimDetails claimDetails);
    }
}
