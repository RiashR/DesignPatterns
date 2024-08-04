using InsuranceClaim.Enums;

namespace InsuranceClaim.Classes
{
    public class ClaimDetails
    {
        public PolicyType PolicyType { get; set; }
        public InsuranceType InsuranceType { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateOfClaim { get; set; }
    }
}
