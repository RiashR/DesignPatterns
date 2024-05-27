using InsuranceQuoteGenerator.Interfaces;

namespace InsuranceQuoteGenerator.Classes
{
    /// <summary>
    /// Comcrete product: Home Insurance
    /// </summary>
    public class HomeInsurance : IQuote
    {
        public string GetQuote() => "Generating a quote for Home insurance...";
    }
}
