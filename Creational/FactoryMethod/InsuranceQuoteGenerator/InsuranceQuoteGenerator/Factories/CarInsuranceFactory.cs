using InsuranceQuoteGenerator.Classes;
using InsuranceQuoteGenerator.Interfaces;

namespace InsuranceQuoteGenerator.Factories
{
    /// <summary>
    /// Concrete creator: Car Insurance factory.
    /// </summary>
    public class CarInsuranceFactory : QuoteGeneratorFactory
    {
        public override IQuoteGenarator GenerateQuote()
        {
            return new CarInsurance();
        }
    }
}
