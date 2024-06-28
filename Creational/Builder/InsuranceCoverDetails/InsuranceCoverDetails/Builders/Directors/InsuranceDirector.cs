using InsuranceCoverDetails.Builders.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCoverDetails.Builders.Directors
{
    /// <summary>
    /// Director class for constructing insurance policies using builders.
    /// </summary>
    public class InsuranceDirector
    {

        /// <summary>
        /// Constructs a basic home insurance policy.
        /// </summary>
        /// <param name="builder">The home insurance builder.</param>
        public void ConstructBasicHomeInsurance(IHomeInsuranceBuilder builder)
        {
            builder.SetAddress("359 Murphy Avenue");
            builder.SetValue(250000);
            builder.AddFireCoverage();
            builder.SetInsuranceType("Basic");
        }

        /// <summary>
        /// Constructs a premium home insurance policy.
        /// </summary>
        /// <param name="builder">The home insurance builder.</param>
        public void ConstructPremiumHomeInsurance(IHomeInsuranceBuilder builder)
        {
            builder.SetAddress("224 Park Drive Gotham City");
            builder.SetValue(500000);
            builder.AddFireCoverage();
            builder.AddTheftCoverage();
            builder.AddFloodCoverage();
            builder.SetInsuranceType("Premium");
        }

        /// <summary>
        /// Constructs a basic car insurance policy.
        /// </summary>
        /// <param name="builder">The car insurance builder.</param>
        public void ConstructBasicCarInsurance(ICarInsuranceBuilder builder)
        {
            builder.SetCarModel("Ford Fiesta ST");
            builder.SetYear(2018);
            builder.AddCollisionCoverage();
            builder.SetExcessAmount(1500);
            builder.SetInsuranceType("Basic");
        }

        /// <summary>
        /// Constructs a premium car insurance policy.
        /// </summary>
        /// <param name="builder">The car insurance builder.</param>
        public void ConstructPremiumCarInsurance(ICarInsuranceBuilder builder)
        {
            builder.SetCarModel("Batmobile");
            builder.SetYear(1966);
            builder.AddCollisionCoverage();
            builder.AddComprehensiveCoverage();
            builder.SetExcessAmount(2500);
            builder.SetInsuranceType("Premium");
        }
    }
}
