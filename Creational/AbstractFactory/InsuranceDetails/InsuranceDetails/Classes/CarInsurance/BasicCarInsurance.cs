using InsuranceDetails.Interfaces;

namespace InsuranceDetails.Classes.CarInsurance
{
    /// <summary>
    /// Concrete implementation of ICarInsurance for basic car insurance.
    /// </summary>
    public class BasicCarInsurance : ICarInsurance
    {
        public void GetCarInsuranceDetails() => Console.WriteLine("Basic Car Insurance: Covers collisions and liability.");
    }
}
