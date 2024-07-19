using InsuranceManager.Enums;

namespace InsuranceManager.Models
{
    public class Policy
    {
        public int PolicyId { get; set; }
        public PolicyHolder PolicyHolder { get; set; }
        public double Premium { get; set; }
        public PolicyType PolicyType { get; set; }
        public InsuranceType InsuranceType { get; set; }

        public Policy(int policyId,PolicyHolder policyHolder, double premium, InsuranceType insuranceType, PolicyType policyType)
        {
            PolicyId = policyId;
            PolicyHolder = policyHolder;
            Premium = premium;
            InsuranceType = insuranceType;
            PolicyType = policyType;
        }
    }
}

