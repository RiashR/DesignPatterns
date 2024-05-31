using InsuranceQuoteGenerator.Classes;
using InsuranceQuoteGenerator.Interfaces;

namespace InsuranceQuoteGenerator.Factories
{
    /// <summary>
    /// Concrete creator: Car Insurance factory.
    /// </summary>
    public class CarInsuranceFactory : IQuoteCreator
    {
        public IQuote GenerateQuote() => new CarInsurance();

    }
}
