using InsuranceQuoteGenerator.Classes;
using InsuranceQuoteGenerator.Interfaces;

namespace InsuranceQuoteGenerator.Factories
{
    /// <summary>
    /// Creator Abstract class.
    /// </summary>
    public abstract class QuoteGeneratorFactory
    {
        public abstract IQuoteGenarator GenerateQuote();
    }
}
