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
            Insurance manager = Insurance.Instance;

            // Add policies
            manager.AddPolicy(new Policy(1 ,new PolicyHolder("Bruce", "Wayne"), 5000.00, InsuranceType.Car, PolicyType.Premium));
            manager.AddPolicy(new Policy(2, new PolicyHolder("Dick", "Grayson"), 2000.00, InsuranceType.Car, PolicyType.Basic));
            manager.AddPolicy(new Policy(3, new PolicyHolder("James", "Gordon"), 1000.00, InsuranceType.Home, PolicyType.Basic));

            // retreive a specific policy
            manager.GetPolicy(2);

            // remove a policy
            manager.RemovePolicy(3);

            // display all policies
            manager.DisplayAllPolicies();
        }
    }
}
