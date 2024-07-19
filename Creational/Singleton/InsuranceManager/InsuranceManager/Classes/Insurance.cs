using InsuranceManager.Models;

namespace InsuranceManager.Classes
{
    public class Insurance
    {
        // static variable to hold the lazy instance of the Insurance class
        private static readonly Lazy<Insurance> _lazyInsuranceManagerInstance =  new(() => new Insurance());

        public Insurance()
        {
            Policies = new List<Policy>();
        }

        // property to get the single instance of the class
        public static Insurance Instance => _lazyInsuranceManagerInstance.Value;

        // a list to hold all policies
        public List<Policy> Policies { get; private set; }

        #region Display Operations

        public void AddPolicy(Policy policy)
        {
            Policies.Add(policy);
        }

        public void RemovePolicy(int policyId)
        {
            var policy = Policies.Find(p => p.PolicyId == policyId);
            Policies.Remove(policy);
        }

        public void GetPolicy(int policyId)
        {
            var policy = Policies.Find(p => p.PolicyId == policyId);

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
