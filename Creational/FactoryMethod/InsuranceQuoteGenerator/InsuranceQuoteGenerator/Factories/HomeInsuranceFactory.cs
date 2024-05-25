using InsuranceQuoteGenerator.Classes;
using InsuranceQuoteGenerator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceQuoteGenerator.Factories
{
    /// <summary>
    /// Concrete creator: Home Insurance factory.
    /// </summary>
    public class HomeInsuranceFactory : QuoteGeneratorFactory
    {
        public override IQuoteGenarator GenerateQuote()
        {
            return new HomeInsurance();
        }
    }
}
