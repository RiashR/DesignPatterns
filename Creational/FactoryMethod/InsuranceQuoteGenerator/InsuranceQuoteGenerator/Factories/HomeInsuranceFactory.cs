using InsuranceQuoteGenerator.Classes;
using InsuranceQuoteGenerator.Interfaces;

namespace InsuranceQuoteGenerator.Factories
{
    /// <summary>
    /// Concrete creator: Home Insurance factory.
    /// </summary>
    public class HomeInsuranceFactory : IQuoteCreator
    {
        public IQuote GenerateQuote() => new HomeInsurance();

    }
}
