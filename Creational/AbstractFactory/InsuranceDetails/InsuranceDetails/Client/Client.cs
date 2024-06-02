using InsuranceDetails.Factories;
using InsuranceDetails.Interfaces;

namespace InsuranceDetails.Client
{
    public class Client
    {
        private readonly ICarInsurance _carInsurance;
        private readonly IHealthInsurance _healthInsurance;

        public Client(IInsuranceFactory insuranceFactory)
        {
            if (insuranceFactory == null)
            {
                throw new ArgumentNullException(nameof(insuranceFactory), "Factory cannot be null.");
            }

            _carInsurance = insuranceFactory.CreateCarInsurance();
            _healthInsurance = insuranceFactory.CreateHealthInsurance();
        }

        public void ShowInsuranceDetails()
        {
            _carInsurance.GetCarInsuranceDetails();
            _healthInsurance.GetHealthInsuranceDetails();
        }
    }
}
