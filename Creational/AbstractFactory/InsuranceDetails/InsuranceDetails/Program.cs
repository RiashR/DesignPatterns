using InsuranceDetails.Client;
using InsuranceDetails.Factories;

class Program
{
    static void Main(string[] args)
    {
        var basicFactory = new BasicInsuranceFactory();
        var basicClient = new Client(basicFactory);
        Console.WriteLine("Basic Insurance Details");
        basicClient.ShowInsuranceDetails();

        Console.WriteLine();

        var premiumFactory = new PremiumInsuranceFactory();
        var premiumClient = new Client(premiumFactory);
        Console.WriteLine("Premium Insurance Details");
        premiumClient.ShowInsuranceDetails();
    }
}
