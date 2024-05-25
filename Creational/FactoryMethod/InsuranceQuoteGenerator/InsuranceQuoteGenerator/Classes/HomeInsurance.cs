using InsuranceQuoteGenerator.Interfaces;

namespace InsuranceQuoteGenerator.Classes
{
    /// <summary>
    /// Comcrete product: Homeinsurance
    /// </summary>
    public class HomeInsurance : IQuoteGenarator
    {
        public string GetQuote()
        {
            return "Generating a quote for Home insurance...";
        }
    }
}
