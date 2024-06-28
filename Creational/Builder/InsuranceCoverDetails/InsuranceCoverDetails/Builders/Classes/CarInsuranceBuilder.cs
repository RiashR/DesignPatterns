using InsuranceCoverDetails.Builders.Interfaces;
using InsuranceCoverDetails.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCoverDetails.Builders.Classes
{
    /// <summary>
    /// Concrete builder for car insurance policies.
    /// </summary>
    public class CarInsuranceBuilder : ICarInsuranceBuilder
    {
        private CarInsurance _carInsurance = new CarInsurance();

        public void SetCarModel(string model)
        {
            _carInsurance.Model = model;
        }

        public void SetYear(int year)
        {
            _carInsurance.Year = year;
        }

        public void AddCollisionCoverage()
        {
            _carInsurance.CollisionCoverage = true;
        }

        public void AddComprehensiveCoverage()
        {
            _carInsurance.ComprehensiveCoverage = true;
        }

        public void SetExcessAmount(double excess)
        {
            _carInsurance.ExcessAmount = excess;
        }

        public void SetInsuranceType(string insuranceType)
        {
            _carInsurance.InsuranceType = insuranceType;
        }

        public CarInsurance Build()
        {
            return _carInsurance;
        }
    }
}
