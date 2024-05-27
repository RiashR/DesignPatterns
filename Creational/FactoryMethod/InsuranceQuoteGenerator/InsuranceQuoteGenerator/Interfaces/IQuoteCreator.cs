using InsuranceQuoteGenerator.Classes;

namespace InsuranceQuoteGenerator.Interfaces
{
    /// <summary>
    /// Creator interface.
    /// </summary>
    public interface IQuoteCreator
    {
        IQuote GenerateQuote();
    }
}
