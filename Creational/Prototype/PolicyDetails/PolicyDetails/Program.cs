using PolicyDetails.Classes;
using PolicyDetails.Enums;
using PolicyDetails.Interfaces;

namespace PolicyDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of CarInsurance
            Insurance originalCarInsurance = OriginalCarInsurance();
            originalCarInsurance.GetDetails();

            // Clone the CarInsurance instance
            Insurance clonedCarInsurance = (Insurance)originalCarInsurance.Clone();
            SetClonedInsurance(clonedCarInsurance);
            clonedCarInsurance.GetDetails();

            // issue with shallow copy... ref Insurance.cs and comment the deep cpoy code.
            //originalCarInsurance.GetDetails();
        }

        private static void SetClonedInsurance(Insurance clonedCarInsurance)
        {
            clonedCarInsurance.PolicyHolder.FirstName = "Dick";
            clonedCarInsurance.PolicyHolder.LastName = "Grayson";
            clonedCarInsurance.Premium = 500.00;
            clonedCarInsurance.PolicyType = PolicyType.Basic;
            clonedCarInsurance.InsuranceType = InsuranceType.Car;
        }

        private static Insurance OriginalCarInsurance()
        {
            return new Insurance(new PolicyHolder("Bruce", "Wayne" ), 1000.00, InsuranceType.Car, PolicyType.Premium);
        }

    }
}
