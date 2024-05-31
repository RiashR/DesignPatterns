using InsuranceDetails.Classes.CarInsurance;
using InsuranceDetails.Classes.HealthInsurance;
using InsuranceDetails.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceDetails.Factories
{
    public class PremiumInsuranceFactory : IInsuranceFactory
    {
        public ICarInsurance CreateCarInsurance() => new PremiumCarInsurance();
        
        public IHealthInsurance CreateHealthInsurance() => new PremiumHealthInsurance();
    }
}
