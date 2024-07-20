using InsuranceManager.Classes;
using InsuranceManager.Enums;
using InsuranceManager.Models;

namespace InsuranceManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Access the singleton instance
            PolicyManager instance = PolicyManager.Instance;

            // Add policies
            instance.AddPolicy(new Policy(1, new PolicyHolder("Bruce", "Wayne"), 5000.00, InsuranceType.Car, PolicyType.Premium));
            instance.AddPolicy(new Policy(2, new PolicyHolder("Dick", "Grayson"), 2000.00, InsuranceType.Car, PolicyType.Basic));
            instance.AddPolicy(new Policy(3, new PolicyHolder("James", "Gordon"), 1000.00, InsuranceType.Home, PolicyType.Basic));

            // display all policies
            instance.DisplayAllPolicies();

            // Create a second instance to prove that it still shares the same instance.
            PolicyManager instance2 = PolicyManager.Instance;

            // retreive a specific policy
            instance2.GetPolicyDetails(2);
        }
    }
}
