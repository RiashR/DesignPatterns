using PolicyDetails.Enums;
using PolicyDetails.Interfaces;

namespace PolicyDetails.Classes
{
    /// <summary>
    /// Represents car insurance.
    /// </summary>
    public class CarInsurance : IInsurance
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Premium { get; set; }
        public InsuranceType InsuranceType { get; set; }
        public PolicyType PolicyType { get; set; }

        public CarInsurance(string policyHolderName,
            string policyHolderLastName,
            double premium,
            InsuranceType insuranceType,
            PolicyType policyType)
        {
            FirstName = policyHolderName;
            LastName = policyHolderLastName;
            Premium = premium;
            InsuranceType = insuranceType;
            PolicyType = policyType;
        }

        public IInsurance Clone()
        {
            return (IInsurance)this.MemberwiseClone();
        }

        public void GetDetails()
        {
            Console.WriteLine($"{PolicyType} {InsuranceType} Insurance \n" +
                                $"First Name: {FirstName} \n" +
                                $"Last Name: {LastName} \n" +
                                $"Premium: {Premium} \n");

        }
    }
}
