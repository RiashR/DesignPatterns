using PolicyDetails.Classes;
using PolicyDetails.Enums;

namespace PolicyDetails.Interfaces
{
    /// <summary>
    /// Defines the interface for insurance prototypes.
    /// </summary>
    public interface IInsurance
    {
        public PolicyHolder PolicyHolder { get; set; }
        InsuranceType InsuranceType { get; set; }
        PolicyType PolicyType { get; set; }
        double Premium { get; set; }
        IInsurance Clone();
        void GetDetails();
    }
}
