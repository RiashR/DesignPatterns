using PolicyDetails.Enums;
using PolicyDetails.Interfaces;

namespace PolicyDetails.Classes
{
    /// <summary>
    /// Represents car insurance.
    /// </summary>
    public class Insurance : IInsurance
    {
        public PolicyHolder PolicyHolder { get; set; }
        public double Premium { get; set; }
        public InsuranceType InsuranceType { get; set; }
        public PolicyType PolicyType { get; set; }

        public Insurance(PolicyHolder policyHolder,
            double premium,
            InsuranceType insuranceType,
            PolicyType policyType)
        {
            PolicyHolder = new PolicyHolder(policyHolder.FirstName, policyHolder.LastName);
            Premium = premium;
            InsuranceType = insuranceType;
            PolicyType = policyType;
        }

        /// <summary>
        /// Creates a clone of the current insurance object.
        /// </summary>
        /// <returns>A clone of the current insurance object.</returns>
        public IInsurance Clone()
        {
            // Shallow copy
            var clone = (Insurance)MemberwiseClone();

            // Deep copy of the PolicyHolder
            clone.PolicyHolder = new PolicyHolder(PolicyHolder.FirstName, PolicyHolder.LastName);
            return clone;
        }

        /// <summary>
        /// Displays the details of the car insurance.
        /// </summary>
        public void GetDetails()
        {
            Console.WriteLine($"{PolicyType} {InsuranceType} Insurance \n" +
                                $"First Name: {PolicyHolder.FirstName} \n" +
                                $"Last Name: {PolicyHolder.LastName} \n" +
                                $"Premium: {Premium} \n");
        }
    }
}
