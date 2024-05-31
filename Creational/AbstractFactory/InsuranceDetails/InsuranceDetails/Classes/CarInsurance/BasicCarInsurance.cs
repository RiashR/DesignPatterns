using InsuranceDetails.Interfaces;

namespace InsuranceDetails.Classes.CarInsurance
{
    public class BasicCarInsurance : ICarInsurance
    {
        public void GetCarInsuranceDetails() => Console.WriteLine("Basic Car Insurance: covers collisions and liability.");
    }
}
