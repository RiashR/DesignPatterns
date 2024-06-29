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
            CarInsurance originalCarInsurance = OriginalCarInsurance();
            originalCarInsurance.GetDetails();

            // Clone the CarInsurance instance
            CarInsurance clonedCarInsurance = (CarInsurance)OriginalCarInsurance().Clone();
            SetClonedInsurance(clonedCarInsurance, InsuranceType.Car, 500.00);
            clonedCarInsurance.GetDetails();

            // Create an instance of HomeInsurance
            HomeInsurance originalHomeInsurance = OriginalHomeInsurance();
            originalHomeInsurance.GetDetails();

            // Clone the HomeInsurance instance
            HomeInsurance clonedHomeInsurance = (HomeInsurance)OriginalHomeInsurance().Clone();
            SetClonedInsurance(clonedHomeInsurance, InsuranceType.Home, 2500.00);
            clonedHomeInsurance.GetDetails();
        }

        private static void SetClonedInsurance<T>(T clonedInsurance, InsuranceType insuranceType, double premium) where T : IInsurance
        {
            clonedInsurance.FirstName = "Dick";
            clonedInsurance.LastName = "Grayson";
            clonedInsurance.PolicyType = PolicyType.Basic;
            clonedInsurance.InsuranceType = insuranceType;
            clonedInsurance.Premium = premium;
        }

        private static CarInsurance OriginalCarInsurance()
        {
            return new CarInsurance
                ("Bruce", "Wayne", 1000.00, InsuranceType.Car, PolicyType.Premium);

        }

        private static HomeInsurance OriginalHomeInsurance()
        {
            return new HomeInsurance
                ("Bruce", "Wayne", 5000, InsuranceType.Car, PolicyType.Premium);
        }
    }
}
