using InsuranceQuoteGenerator.Client;

class Program
{
    static void Main(string[] args)
    {
        Client client = new Client();
        client.WelcomeMessage();
        client.QuoteGenerator();
        Console.ReadKey();
    }
}