using InsurancePortfolio.Classes;

namespace InsurancePortfolio
{
    /// <summary>
    /// Client:  demonstrates the composite pattern by creating individual policies and 
    /// packages, then displaying their structure.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create individual policies (Leaves)
            var carInsurance = new IndividualPolicy("Car Insurance");
            var tyreInsurance = new IndividualPolicy("Tyre Insurance");
            var homeInsurance = new IndividualPolicy("Home Insurance");
            var homeContentsInsurance = new IndividualPolicy("Home Contents Insurance");

            // Create policy packages (Composites)
            var carInsurancePackage = new PolicyPackage("Car Insurance Package");
            carInsurancePackage.Add(carInsurance);
            carInsurancePackage.Add(tyreInsurance);

            var homeInsurancePackage = new PolicyPackage("Home Insurance Package");
            homeInsurancePackage.Add(homeInsurance);
            homeInsurancePackage.Add(homeContentsInsurance);

            // General Insurance Package (Composite)
            var generalInsurancePackage = new PolicyPackage("General Insurance Package");
            generalInsurancePackage.Add(carInsurancePackage);
            generalInsurancePackage.Add(homeInsurancePackage);

            // Display the insurance packages
            Console.WriteLine("Insurance Package Details:");
            generalInsurancePackage.DisplayDetails();
        }
    }
}
