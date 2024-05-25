using InsuranceQuoteGenerator.Interfaces;

namespace InsuranceQuoteGenerator.Classes
{
    /// <summary>
    /// Concrete product: Car Insurance.
    /// </summary>
    public class CarInsurance : IQuoteGenarator
    {
        public string GetQuote()
        {
            return "Generating a quote for Car insurance...";
        }
    }
}
