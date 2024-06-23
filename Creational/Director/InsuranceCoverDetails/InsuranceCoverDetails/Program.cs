using InsuranceCoverDetails.Builders.Classes;
using InsuranceCoverDetails.Builders.Directors;
using InsuranceCoverDetails.Builders.Interfaces;
using InsuranceCoverDetails.Models;

namespace InsuranceCoverDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IHomeInsuranceBuilder homeInsuranceBuilder = new HomeInsuranceBuilder();
            ICarInsuranceBuilder carInsuranceBuilder = new CarInsuranceBuilder();
            var director = new InsuranceDirector();

            director.ConstructBasicHomeInsurance(homeInsuranceBuilder);
            HomeInsurance basicHomeInsurance = homeInsuranceBuilder.Build();
            Console.WriteLine(basicHomeInsurance);

            director.ConstructPremiumHomeInsurance(homeInsuranceBuilder);
            HomeInsurance premiumHomeInsurance = homeInsuranceBuilder.Build();
            Console.WriteLine(premiumHomeInsurance);

            director.ConstructBasicCarInsurance(carInsuranceBuilder);
            CarInsurance basicCarInsurance = carInsuranceBuilder.Build();
            Console.WriteLine(basicCarInsurance);

            director.ConstructPremiumCarInsurance(carInsuranceBuilder);
            CarInsurance premiumCarInsurance = carInsuranceBuilder.Build();
            Console.WriteLine(premiumCarInsurance);
        }
    }
}
