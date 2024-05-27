using InsuranceQuoteGenerator.Interfaces;

namespace InsuranceQuoteGenerator.Classes
{
    /// <summary>
    /// Concrete product: Car Insurance.
    /// </summary>
    public class CarInsurance : IQuote
    {
        public string GetQuote() => "Generating a quote for Car insurance...";
    }
}
