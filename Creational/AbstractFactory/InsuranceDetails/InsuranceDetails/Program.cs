using InsuranceDetails.Client;
using InsuranceDetails.Factories;

class Program
{
    static void Main(string[] args)
    {
        var basicFactory = new BasicInsuranceFactory();
        var basicClient = new Client(basicFactory);
        basicClient.DisplayMessage("Basic Insurance Details");
        basicClient.ShowInsuranceDetails();

        Console.WriteLine();

        var premiumFactory = new PremiumInsuranceFactory();
        var premiumClient = new Client(premiumFactory);
        basicClient.DisplayMessage("Premium Insurance Details");
        premiumClient.ShowInsuranceDetails();
    }
}
