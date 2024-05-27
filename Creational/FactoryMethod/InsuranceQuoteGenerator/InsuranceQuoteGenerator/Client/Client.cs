using InsuranceQuoteGenerator.Enums;
using InsuranceQuoteGenerator.Factories;
using InsuranceQuoteGenerator.Interfaces;

namespace InsuranceQuoteGenerator.Client
{
    // Client class
    public class Client
    {
        public void QuoteGenerator()
        {
            // Dynamically populate Options for insurance types
            InsuranceType[] options = (InsuranceType[])Enum.GetValues(typeof(InsuranceType));

            // Create a menu for insurance selection
            ConsoleMenu menu = new ConsoleMenu(options);

            // Run the menu and get the selected insurance type
            InsuranceType selectedType = menu.Run();

            // Create appropriate factory based on selected insurance type
            IQuoteCreator factory;
            switch (selectedType)
            {
                case InsuranceType.Car:
                    factory = new CarInsuranceFactory();
                    break;
                case InsuranceType.Home:
                    factory = new HomeInsuranceFactory();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }

            // Use factory to create insurance object and get quote
            IQuote quoteGenarator = factory.GenerateQuote();  
            var result = quoteGenarator.GetQuote();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(result.ToString());     
            Console.ResetColor();
        }

        public void WelcomeMessage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to the Insurance Quotation System!");
            Console.ResetColor();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}
