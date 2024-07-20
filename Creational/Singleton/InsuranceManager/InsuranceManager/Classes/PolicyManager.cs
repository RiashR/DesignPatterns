using InsuranceManager.Models;

namespace InsuranceManager.Classes
{
    public class PolicyManager
    {
        // static variable to hold the lazy instance of the class
        private static readonly Lazy<PolicyManager> _lazyInsuranceManagerInstance =  new(() => new PolicyManager());

        // property to get the single instance
        public static PolicyManager Instance => _lazyInsuranceManagerInstance.Value;

        // a list to hold all policies
        public List<Policy> Policies { get; private set; }

        private PolicyManager()
        {
            Policies = new List<Policy>();
        }

        #region Display Operations

        public void AddPolicy(Policy policy)
        {
            Policies.Add(policy);
        }

        public Policy GetPolicy(int policyId)
        {
            return Policies.Find(p => p.PolicyId == policyId);
        }

        public void GetPolicyDetails(int policyId)
        {
            var policy = GetPolicy(policyId);
            Display(policy);
        }

        public void DisplayAllPolicies()
        {
            foreach (var policy in Policies)
            {
                Display(policy);
            }
        }

        private static void Display(Policy policy)
        {
            Console.WriteLine($"Policy #{policy.PolicyId} \n" +
                                    $"{policy.PolicyType} {policy.InsuranceType} Insurance \n" +
                                    $"First Name: {policy.PolicyHolder.FirstName} \n" +
                                    $"Last Name: {policy.PolicyHolder.LastName} \n" +
                                    $"Premium: {policy.Premium} \n");
        }

        #endregion
    }
}
